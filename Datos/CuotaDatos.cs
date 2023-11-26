using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Datos
{
    public class CuotaDatos
    {
       public CuotaDatos() {
        }

        public void GenerarCuota(long clienteID, string tipoCuota, float importe, DateTime fechaEmision, DateTime fechaVencimiento)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Crear comando para insertar en la tabla Cuota
                MySqlCommand cmdCuota = new MySqlCommand("GenerarCuota", sqlCon);
                cmdCuota.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetros IN
                cmdCuota.Parameters.Add("pClienteID", MySqlDbType.Int32).Value = clienteID;
                cmdCuota.Parameters.Add("pTipoCuota", MySqlDbType.VarChar, 40).Value = tipoCuota;
                cmdCuota.Parameters.Add("pImporte", MySqlDbType.Decimal).Value = importe;
                cmdCuota.Parameters.Add("pFechaEmision", MySqlDbType.Date).Value = fechaEmision;
                cmdCuota.Parameters.Add("pFechaVencimiento", MySqlDbType.Date).Value = fechaVencimiento;

                // Conectar y ejecutar el stored procedure
                sqlCon.Open();
                cmdCuota.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar la cuota: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }


        public List<Cuota> ObtenerCuotasPendientes(long clienteID)
        {
            List<Cuota> cuotasPendientes = new List<Cuota>();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Crear comando para obtener cuotas pendientes
                MySqlCommand cmd = new MySqlCommand("ObtenerCuotasPendientes", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetros IN
                cmd.Parameters.Add("pClienteID", MySqlDbType.Int32).Value = clienteID;

                // Conectar y ejecutar el stored procedure
                sqlCon.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cuota cuota = new Cuota(
                            reader.GetInt32("Cuota_ID"),
                            ConvertirTipoCuota(reader.GetString("TipoCuota")),
                            reader.GetFloat("Importe"),
                            reader.GetDateTime("FechaEmision"),
                            reader.GetDateTime("FechaVencimiento")
                            );

                        cuotasPendientes.Add(cuota);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las cuotas pendientes: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return cuotasPendientes;
        }



        public static TipoDeCuotaEnum ConvertirTipoCuota(string valor)
        {
            switch (valor.ToUpper())
            {
                case "DIARIA":
                    return TipoDeCuotaEnum.DIARIA;
                case "SEMANAL":
                    return TipoDeCuotaEnum.SEMANAL;
                case "MENSUAL":
                    return TipoDeCuotaEnum.MENSUAL;
                case "CUOTA_SOCIO":
                    return TipoDeCuotaEnum.CUOTA_SOCIO;
                default:
                    throw new ArgumentException($"No se pudo convertir '{valor}' a TipoDeCuotaEnum.");
            }
        }


        public void PagarCuotas(List<Cuota> cuotas, string formaPago, DateTime fechaPago)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand cmd = new MySqlCommand("PagarCuotas", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                List<long> cuotaIDs = cuotas.Select(c => c.getCuota_id()).ToList();
                cmd.Parameters.Add("pCuotaIDs", MySqlDbType.VarChar).Value = string.Join(",", cuotaIDs);

                // Agregar los nuevos parámetros
                cmd.Parameters.Add("pFormaPago", MySqlDbType.VarChar).Value = formaPago;
                cmd.Parameters.Add("pFechaPago", MySqlDbType.Date).Value = fechaPago;

                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al pagar las cuotas: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }


    }
}

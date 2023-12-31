﻿using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class ClienteDatos
    {

        CuotaDatos cuotaDatos = new CuotaDatos();
        public Cliente IdentificarCliente(long dni)
        {
            Cliente? cli = null;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // instanciar conexion
                sqlCon = Conexion.getInstancia().CrearConexion();
                // crear comando de tipo storeProcedure
                MySqlCommand cmd = new MySqlCommand("IdentificarCliente", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Agregar parámetros IN
                cmd.Parameters.Add("clienteDni", MySqlDbType.VarChar, 40).Value = dni;
                // Agregar parámetros OUT
                cmd.Parameters.Add("cCLIENTE_ID", MySqlDbType.Int32);
                cmd.Parameters["cCLIENTE_ID"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cNombre", MySqlDbType.VarChar, 40);
                cmd.Parameters["cNombre"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cApellido", MySqlDbType.VarChar, 40);
                cmd.Parameters["cApellido"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cFec_nacimiento", MySqlDbType.Date);
                cmd.Parameters["cFec_nacimiento"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cDomicilio", MySqlDbType.VarChar, 40);
                cmd.Parameters["cDomicilio"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cEmail", MySqlDbType.VarChar, 40);
                cmd.Parameters["cEmail"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cTelefono", MySqlDbType.VarChar, 20);
                cmd.Parameters["cTelefono"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cDni", MySqlDbType.Int64);
                cmd.Parameters["cDni"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cAptoFisicoVigente", MySqlDbType.Bit);
                cmd.Parameters["cAptoFisicoVigente"].Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("cCarnet_ID", MySqlDbType.Int32);
                cmd.Parameters["cCarnet_ID"].Direction = System.Data.ParameterDirection.Output;

                // conectar y almacenar respuesta
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                cli = new Cliente(
                    cmd.Parameters["cNombre"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["cNombre"].Value) : string.Empty,
                    cmd.Parameters["cApellido"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["cApellido"].Value) : string.Empty,
                    cmd.Parameters["cFec_nacimiento"].Value != DBNull.Value ? Convert.ToDateTime(cmd.Parameters["cFec_nacimiento"].Value) : DateTime.MinValue,
                    cmd.Parameters["cDomicilio"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["cDomicilio"].Value) : string.Empty,
                    cmd.Parameters["cEmail"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["cEmail"].Value) : string.Empty,
                    cmd.Parameters["cTelefono"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["cTelefono"].Value) : string.Empty,
                    cmd.Parameters["cDni"].Value != DBNull.Value ? Convert.ToInt64(cmd.Parameters["cDni"].Value) : 0,
                    cmd.Parameters["cAptoFisicoVigente"].Value != DBNull.Value ? Convert.ToBoolean(cmd.Parameters["cAptoFisicoVigente"].Value) : false,
                    cmd.Parameters["cCarnet_ID"].Value != DBNull.Value ? Convert.ToInt32(cmd.Parameters["cCarnet_ID"].Value) : 0
                );

                cli.setCLIENTE_ID(cmd.Parameters["cCLIENTE_ID"].Value != DBNull.Value ? Convert.ToInt64(cmd.Parameters["cCLIENTE_ID"].Value) : 0);

            }
            catch
            {
                throw;
                
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
            
            return cli;
        }


        public void GuardarNuevoCliente(Cliente nuevoCliente)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                // instanciar conexión
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Verificar si el cliente ya existe en la base de datos
                if (!ClienteExiste(nuevoCliente.getDni(), sqlCon))
                {
                    // crear comando de tipo stored procedure
                    MySqlCommand cmd = new MySqlCommand("GuardarNuevoCliente", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // agregar parámetros IN
                    cmd.Parameters.Add("pNombre", MySqlDbType.VarChar, 40).Value = nuevoCliente.getNombre();
                    cmd.Parameters.Add("pApellido", MySqlDbType.VarChar, 40).Value = nuevoCliente.getApellido();
                    cmd.Parameters.Add("pFec_nacimiento", MySqlDbType.Date).Value = nuevoCliente.getFec_nacimiento();
                    cmd.Parameters.Add("pDomicilio", MySqlDbType.VarChar, 40).Value = nuevoCliente.getDomicilio();
                    cmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 40).Value = nuevoCliente.getEmail();
                    cmd.Parameters.Add("pTelefono", MySqlDbType.VarChar, 20).Value = nuevoCliente.getTelefono();
                    cmd.Parameters.Add("pDni", MySqlDbType.Int64).Value = nuevoCliente.getDni();
                    cmd.Parameters.Add("pAptoFisicoVigente", MySqlDbType.Bit).Value = nuevoCliente.getAptoFisicoVigente();
                    cmd.Parameters.Add("pCarnet_ID", MySqlDbType.Int32).Value = nuevoCliente.getCarnet_ID();

                    // conectar y ejecutar el stored procedure
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // El cliente ya existe
                    MessageBox.Show("El cliente ya se encuentra registrado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, registrar en un archivo de registro)
                Console.WriteLine($"Error al guardar el nuevo cliente: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        private bool ClienteExiste(long dni, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Cliente WHERE Dni = @Dni", connection);
            cmd.Parameters.Add("@Dni", MySqlDbType.Int64).Value = dni;

            connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            return count > 0;
        }

        public void ActualizarCliente(Cliente cliente)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                if (ClienteExiste(cliente.getDni(), sqlCon))
                {
                    MySqlCommand cmd = new MySqlCommand("ActualizarCliente", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("pDni", MySqlDbType.Int64).Value = cliente.getDni();
                    cmd.Parameters.Add("pDomicilio", MySqlDbType.VarChar, 40).Value = cliente.getDomicilio();
                    cmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 40).Value = cliente.getEmail();
                    cmd.Parameters.Add("pTelefono", MySqlDbType.VarChar, 20).Value = cliente.getTelefono();

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente no se encuentra registrado en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el cliente: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public void AsociarCliente(long clienteID, float precioActividad, DateTime fechaHoy, DateTime fechaVencimiento)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                if (ClienteYaAsociado(clienteID, sqlCon))
                {
                    MessageBox.Show("Error: El cliente ya se encuentra asociado con anterioridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No es necesario lanzar una excepción aquí, simplemente salimos del método.
                }

                MySqlCommand cmd = new MySqlCommand("AsociarCliente", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("pClienteID", MySqlDbType.Int64).Value = clienteID;
                cmd.Parameters.Add("pFechaAlta", MySqlDbType.Date).Value = DateTime.Now;

                sqlCon.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente asociado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cuotaDatos.GenerarCuota(clienteID, TipoDeCuotaEnum.MENSUAL.ToString(), precioActividad, fechaHoy, fechaVencimiento);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al asociar el cliente: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public bool ClienteYaAsociado(long clienteID, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM socio WHERE Cliente_ID = @ClienteID", connection);
            cmd.Parameters.Add("@ClienteID", MySqlDbType.Int64).Value = clienteID;

            connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            return count > 0;
        }

        public bool ClienteEsNoSocio(long clienteID, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM noSocio WHERE Cliente_ID = @ClienteID", connection);
            cmd.Parameters.Add("@ClienteID", MySqlDbType.Int64).Value = clienteID;

            connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            return count > 0;
        }


        public List<Actividad> ActividadesCliente (long clienteID)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            List<Actividad> actividades = new List<Actividad>();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string cmdString = @"SELECT actividad.nombre, actividad.frecuencia, actividad.precio
                                       FROM actividad 
                                      INNER JOIN actividad_cliente ON actividad.ACTIVIDAD_ID = actividad_cliente.ActividadID 
                                      INNER JOIN noSocio ON actividad_cliente.NoSocio_ID = noSocio.NoSocio_ID 
                                      INNER JOIN cliente ON noSocio.Cliente_ID = cliente.CLIENTE_ID 
                                      WHERE cliente.CLIENTE_ID = @ClienteID
                                        AND actividad_cliente.VigenciaActividad = current_date()";
                MySqlCommand cmd = new MySqlCommand(cmdString, sqlCon);
                cmd.Parameters.Add("@ClienteID", MySqlDbType.Int64).Value= clienteID;

                sqlCon.Open();
                MySqlDataReader result = cmd.ExecuteReader();
                

                while (result.Read())
                {
                    Actividad actividad = new Actividad(
                        Convert.ToString(result["nombre"])!,
                        Convert.ToInt64(result["precio"]),
                        Convert.ToString(result["frecuencia"])!
                    );
                    actividades.Add(actividad);
                }

                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return actividades;

        }

        public void RegistrarNoSocio (long clienteID, MySqlConnection sqlCon)
        {

            string cmdString = @"INSERT INTO noSocio(NoSocio_ID, Cliente_ID, FechaAlta) values 
                                 (default, @clienteID , current_date() );";
            MySqlCommand cmd = new MySqlCommand(cmdString, sqlCon);
            cmd.Parameters.Add("@ClienteID", MySqlDbType.Int64).Value = clienteID;
            sqlCon.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            sqlCon.Close();

        }

        public void RegistrarActividadCliente (string nombreActividad, long clienteID, MySqlConnection sqlCon)
        {
            // Obtengo el id de la actividad
            MySqlCommand cmdActividadID = new MySqlCommand("SELECT Actividad_ID FROM actividad WHERE nombre = @nombreActividad", sqlCon);
            cmdActividadID.Parameters.Add("@nombreActividad", MySqlDbType.String).Value = nombreActividad;

            // Obtengo el ID como NoSocio
            MySqlCommand cmdNoSocioID = new MySqlCommand("SELECT NoSocio_ID FROM noSocio WHERE Cliente_ID = @ClienteID", sqlCon);
            cmdNoSocioID.Parameters.Add("@ClienteID", MySqlDbType.Int32).Value = clienteID;

            sqlCon.Open();

            int actividadID = Convert.ToInt32(cmdActividadID.ExecuteScalar());
            int noSocioID = Convert.ToInt32(cmdNoSocioID.ExecuteScalar());

            // Ejecuto insert a la base
            MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO actividad_cliente (NoSocio_ID, ActividadID, VigenciaActividad) values (@NoSocio_ID, @Actividad_ID, current_date());", sqlCon);
            cmdInsert.Parameters.Add("@Actividad_ID", MySqlDbType.Int32).Value = actividadID;
            cmdInsert.Parameters.Add("@NoSocio_ID", MySqlDbType.Int32).Value = noSocioID;
            cmdInsert.ExecuteNonQuery();
            
            sqlCon.Close();
        }

        public DataTable listarClientes()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            DataTable datatable = new DataTable();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand cmd = new MySqlCommand("SELECT * from cliente;", sqlCon);
                cmd.CommandType = System.Data.CommandType.Text;
                sqlCon.Open();
                datatable.Load(cmd.ExecuteReader());
                sqlCon.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return datatable;
        }

        public DataTable listarDeudores()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            DataTable datatable = new DataTable();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string consulta = "SELECT c.CLIENTE_ID, c.nombre, c.apellido, cu.FechaVencimiento " +
                  "FROM cliente c " +
                  "JOIN cuota cu ON c.CLIENTE_ID = cu.Cliente_ID " +
                  "WHERE cu.FechaVencimiento < NOW() AND cu.FechaPago IS NULL";
                MySqlCommand cmd = new MySqlCommand(consulta, sqlCon);
                cmd.CommandType = System.Data.CommandType.Text;
                sqlCon.Open();
                datatable.Load(cmd.ExecuteReader());
                sqlCon.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
            

            return datatable;
        }
    }
}

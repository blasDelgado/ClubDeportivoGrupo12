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
    public class ActividadesDatos
    {
       public ActividadesDatos() {
        }

        public MySqlDataReader listarActividades()
        {
            MySqlConnection sqlCon = new MySqlConnection();            
            MySqlDataReader resultado;
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * from actividad;", sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            sqlCon.Open();
            resultado = cmd.ExecuteReader();
            
            return resultado;
        }

        public void agregarActividad(Actividad act)
        {            
            MySqlConnection sqlCon = new MySqlConnection();
            sqlCon = Conexion.getInstancia().CrearConexion();                      
            string sql = $"insert into actividad(ACTIVIDAD_ID, nombre , frecuencia , precio) values (default , '{act.getNombreActividad()}', '{act.getFrecuencia()}', '{act.getPrecioActividad()}');";
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            sqlCon.Open();
            cmd.ExecuteReader();
            sqlCon.Close();
        }

     
        public void actualizarActividad(Actividad act)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            sqlCon = Conexion.getInstancia().CrearConexion();
            string sql = $"UPDATE actividad SET nombre ='{act.getNombreActividad()}', frecuencia = '{act.getFrecuencia()}', precio = {act.getPrecioActividad()} WHERE nombre = '{act.getNombreActividad()}';";
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            sqlCon.Open();
            cmd.ExecuteReader();
            sqlCon.Close();
        }

        public Actividad BuscarActividadPorNombre(string nombreActividad)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = "SELECT nombre, precio, frecuencia FROM actividad WHERE nombre = @pNombreActividad";

                MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                cmd.Parameters.Add("@pNombreActividad", MySqlDbType.VarChar, 40).Value = nombreActividad;

                sqlCon.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Actividad(
                            reader.GetString("nombre"),
                            reader.GetFloat("precio"),
                            reader.GetString("frecuencia")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar la actividad por nombre: {ex.Message}");
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return null;
        }


    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class ClienteDatos
    {
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



    }
}

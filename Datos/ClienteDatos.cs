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

    }
}

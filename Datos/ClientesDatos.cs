using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class ClientesDatos
    {
        public ClientesDatos()
        {
        }

        public MySqlDataReader listarClientes()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlDataReader resultado;
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * from cliente;", sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            sqlCon.Open();
            resultado = cmd.ExecuteReader();

            return resultado;
        }

        public MySqlDataReader listarDeudores()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            MySqlDataReader resultado;
            sqlCon = Conexion.getInstancia().CrearConexion();
            string consulta = "SELECT c.CLIENTE_ID, c.nombre, c.apellido, cu.FechaVencimiento " +
                  "FROM cliente c " +
                  "JOIN cuota cu ON c.CLIENTE_ID = cu.Cliente_ID " +
                  "WHERE cu.FechaVencimiento < NOW() AND cu.FechaPago IS NULL";
            MySqlCommand cmd = new MySqlCommand(consulta, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            sqlCon.Open();
            resultado = cmd.ExecuteReader();

            return resultado;
        }
    }
}

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
    }
}

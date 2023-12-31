﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class UsuariosLogin
    {
        // La idea de esta clase es atomizar la lógica para acceder al PROCEDURE de identificacion de usuarios en la base de datos
        // para ello, se crea un metodo que con el usuario y pass devuelve una tabla de fila única (si existe) con el rol del usuario
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // instanciamos una conexion UNICA
                sqlCon = Conexion.getInstancia().CrearConexion();
                // Configuramos el comando
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                // abrimos la conexion
                sqlCon.Open();
                // ejecutamos el procedure a traves del comando
                resultado = comando.ExecuteReader(); 
                tabla.Load(resultado); 
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch
            {
                throw;
            }
            // como proceso final -> Cerramos la conexion abierta
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class usuariosRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=holaa;Uid=root;Password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<usuarios> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from usuarios";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                usuarios usuario = null;
                List<usuarios> a = new List<usuarios>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetInt32(4));
                    usuario = new usuarios(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetInt32(4));
                    a.Add(usuario);
                }

                con.Close();
                return a;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}
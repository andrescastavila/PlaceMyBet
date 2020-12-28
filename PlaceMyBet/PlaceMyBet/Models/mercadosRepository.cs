using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class mercadosRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=holaa;Uid=root;Password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<mercados> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from mercados";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                mercados mercado = null;
                List<mercados> m = new List<mercados>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetString(4) + " " + res.GetInt32(5) + " " + res.GetInt32(6));
                    mercado = new mercados(res.GetString(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetString(4), res.GetInt32(5), res.GetInt32(6));
                    m.Add(mercado);
                }

                con.Close();
                return m;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}
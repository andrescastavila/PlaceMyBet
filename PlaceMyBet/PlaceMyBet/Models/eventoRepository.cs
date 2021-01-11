using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class eventoRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=holaa;Uid=root;Password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal List<evento> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from evento";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                evento evento = null;
                List<evento> e = new List<evento>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2));
                    evento = new evento(res.GetInt32(0), res.GetString(1), res.GetString(2));
                    e.Add(evento);
                }

                con.Close();
                return e;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }




        internal List<eventoDTO> RetrieveDTO()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select equipo_local, equipo_visitante from evento";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                eventoDTO evento = null;
                List<eventoDTO> e = new List<eventoDTO>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: "  +  res.GetString(0) + " " + res.GetString(1));
                    evento = new eventoDTO(res.GetString(0), res.GetString(1));
                    e.Add(evento);
                }

                Debug.WriteLine("--------------- Todo ha ido bien");

                con.Close();
                return e;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }
    }
}
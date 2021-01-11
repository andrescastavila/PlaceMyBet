using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuestasRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=holaa;Uid=root;Password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<apuestas> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from apuestas";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                apuestas apuesta = null;
                List<apuestas> a = new List<apuestas>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetInt32(4) + " " + res.GetInt32(5));
                    apuesta = new apuestas(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetInt32(4), res.GetInt32(5));
                    a.Add(apuesta);
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



        internal List<apuestasDTO> RetrieveDTO()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT usuarios.eMail,mercados.tipoMercado, apuestas.tipoApuesta, apuestas.cuota, apuestas.ingreso FROM usuarios INNER JOIN apuestas ON apuestas.idUsuario LIKE usuarios.idUsuario INNER JOIN mercados ON apuestas.idMercado LIKE mercados.idMercado";
           

            try
            {
                con.Open(); //abrimos conexion con la base de datos
                MySqlDataReader res = command.ExecuteReader();

                apuestasDTO a = null;
                List<apuestasDTO> apuestas = new List<apuestasDTO>();

                while (res.Read())
                {
                    a = new apuestasDTO(res.GetString(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetFloat(4));
                    apuestas.Add(a);
                }

                con.Close();
                return apuestas;
            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }







        internal List<apuestas> RetrieveByEmail(String eMail)
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT mercados.idEvento, mercados.tipoMercado, apuestas.tipoApuesta, apuestas.cuota, apuestas.ingreso FROM usuarios, apuestas, mercados WHERE usuarios.idUsuario = apuestas.idUsuario AND mercados.idMercado=apuestas.idMercado AND usuarios.eMail=@A";
            command.Parameters.AddWithValue("@A", eMail);

            try
            {
                con.Open(); //abrimos conexion con la base de datos
                MySqlDataReader res = command.ExecuteReader();

                apuestas a = null;
                List<apuestas> apuesta = new List<apuestas>();

                while (res.Read())
                {
                    a = new apuestas(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetInt32(4),res.GetInt32(5));
                    apuesta.Add(a);
                }

                con.Close();
                return apuesta;

            }
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexión");
                return null;
            }
        }

    }
}
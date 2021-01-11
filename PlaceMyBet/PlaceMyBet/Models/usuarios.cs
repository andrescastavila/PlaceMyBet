using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class usuarios
    {

        public usuarios(int idUsuario, string nombre, string apellido, string email, int Edad )
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.Edad = Edad;

            Debug.WriteLine("");
        }

        public int idUsuario { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String email { get; set; }
        public int Edad { get; set; }
       
    }


   
    

}

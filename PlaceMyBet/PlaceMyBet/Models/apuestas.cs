using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuestas
    {


        public apuestas(int idMercado, string tipoApuesta, string cuota, string ingreso, int idUsuario, int idApuesta)
        {
            this.idMercado = idMercado;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.ingreso = ingreso;
            this.idUsuario = idUsuario;
            this.idApuesta = idApuesta;
        }

        public int idMercado { get; set; }
        public String tipoApuesta { get; set; }
        public String cuota { get; set; }
        public String ingreso { get; set; }
        public int idUsuario { get; set; }
        public int idApuesta { get; set; }
    }






    public class apuestasDTO
    {
        public apuestasDTO(string email, string tipoMercado, string cuota, string tipoApuesta, float ingreso)
        {
            this.email = email;
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.tipoApuesta = tipoApuesta;
            this.ingreso = ingreso;
        }
        public String email { get; set; }
        public String tipoMercado { get; set; }
        public String cuota { get; set; }
        public String tipoApuesta { get; set; }
        public float ingreso { get; set; }
    }


    public class apuestasById
    {
        public apuestasById(string email, string tipoMercado, string tipoApuesta, string cuota, float ingreso)
        {
            this.email = email;
            this.tipoMercado = tipoMercado;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.ingreso = ingreso;
        }
        public String email { get; set; }
        public String tipoMercado { get; set; }
        public String tipoApuesta { get; set; }
        public String cuota { get; set; }
        public float ingreso { get; set; }
    }

}

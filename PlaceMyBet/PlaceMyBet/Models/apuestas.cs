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
}

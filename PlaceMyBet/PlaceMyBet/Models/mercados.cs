using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class mercados
    {
        public mercados(string tipoMercado, string cuotaUnder, string cuotaOver, string apostadoUnder, string apostadoOver, int idMercado, int idEvento)
        {
            this.tipoMercado = tipoMercado;
            this.cuotaUnder = cuotaUnder;
            this.cuotaOver = cuotaOver;
            this.apostadoUnder = apostadoUnder;
            this.apostadoOver = apostadoOver;
            this.idMercado = idMercado;
            this.idEvento = idEvento;
        }

        public String tipoMercado { get; set; }
        public String cuotaUnder { get; set; }
        public String cuotaOver { get; set; }
        public String apostadoUnder { get; set; }
        public String apostadoOver { get; set; }
        public int idMercado { get; set; }
        public int idEvento { get; set; }
    }


    public class mercadosDTO
    {
        public mercadosDTO(string tipoMercado, string cuotaUnder, string cuotaOver)
        {
            this.tipoMercado = tipoMercado;
            this.cuotaUnder = cuotaUnder;
            this.cuotaOver = cuotaOver;
        }

        public String tipoMercado { get; set; }
        public String cuotaUnder { get; set; }
        public String cuotaOver { get; set; }
    }



   

}

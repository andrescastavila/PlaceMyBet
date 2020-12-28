using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class evento
    {
        public evento(int idEvento, string equipoLocal, string equipoVisitante)
        {
            this.idEvento = idEvento;
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
        }

        public int idEvento { get; set; }
        public String equipoLocal { get; set; }
        public String equipoVisitante { get; set; }
    }
}

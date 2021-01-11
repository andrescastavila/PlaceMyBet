using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class mercadosController : ApiController
    {
        // GET: api/mercados
        public IEnumerable<mercados> Get()
        {
            var repo = new mercadosRepository();
            List<mercados> mercado = repo.Retrieve();
            return mercado;
        }


        // GET: api/mercados/5
        public mercados Get(int id)
        {
            /*var repo = new mercadosRepository();
           mercados mercado = repo.Retrieve();*/
            return null;
        }

        // POST: api/mercados
        public void Post([FromBody] mercadosDTO mercado)
        {
            var repo = new mercadosRepository();
            repo.RetrieveDTO();
        }

        // PUT: api/mercados/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/mercados/5
        public void Delete(int id)
        {
        }
    }
}

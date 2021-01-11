using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class eventoController : ApiController
    {
        // GET: api/evento
        public IEnumerable<evento> Get()
        {
            var repo = new eventoRepository();
            List<evento> eventos = repo.Retrieve();
            return eventos;
        }

        // GET: api/evento/5
        public evento Get(int id)
        {
            /*var repo = new eventoRepository();
           evento eventoss= repo.Retrieve();*/
            return null;
        }

        // POST: api/evento
        public void Post([FromBody]eventoDTO evento)
        {
            var repo = new eventoRepository();
            repo.RetrieveDTO();
        }

        // PUT: api/evento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/evento/5
        public void Delete(int id)
        {
        }
    }
}

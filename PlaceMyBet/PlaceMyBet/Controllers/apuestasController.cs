using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class apuestasController : ApiController
    {
        // GET: api/apuestas
        public IEnumerable<apuestas> Get()
        {
            var repo = new apuestasRepository();
            List<apuestas> apuesta = repo.Retrieve();
            return apuesta;
        }

        // GET: api/apuestas/5
        public apuestas Get(int id)
        {
            /*var repo = new apuestasRepository();
            apuestas apuesta = repo.Retrieve();*/
            return null;
        }



        // GET: api/apuestas?usuario=email
        public IEnumerable<apuestas> GetApuestas(string Email)
        {
            var repo = new apuestasRepository();
            List<apuestas> apuesta = repo.RetrieveByEmail(Email);
            return apuesta;
        }

        // GET: api/apuestas?
        public IEnumerable<apuestasById> GetIdMercado(int idMercado)
        {
            var repo = new apuestasRepository();
            List<apuestasById> apuesta = repo.RetrieveByMercado(idMercado);
            return apuesta;
        }

        // POST: api/apuestas
        public void Post([FromBody]apuestasDTO apuesta)
        {
            var repo = new apuestasRepository();
            repo.RetrieveDTO();
        }

        // PUT: api/apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/apuestas/5
        public void Delete(int id)
        {
        }
    }
}

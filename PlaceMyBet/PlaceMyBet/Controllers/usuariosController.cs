using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class usuariosController : ApiController
    {
        // GET: api/usuarios
        public IEnumerable<usuarios> Get()
        {
            var repo = new usuariosRepository();
            List<usuarios> usuario = repo.Retrieve();
            return usuario;
        }

        // GET: api/usuarios/5
        public usuarios Get(int id)
        {
            /*var repo = new apuestasRepository();
            apuestas apuesta = repo.Retrieve();*/
            return null;
        }

        // POST: api/usuarios
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/usuarios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/usuarios/5
        public void Delete(int id)
        {
        }
    }
}

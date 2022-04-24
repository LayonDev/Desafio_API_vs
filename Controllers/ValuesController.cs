using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Desafio_API_vs.Models;

namespace Desafio_API_vs.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Reunion> Get()
        {
            IEnumerable<Reunion> lista;
            using (DesafioDBEntities db = new DesafioDBEntities())
            {
                lista =db.Reunion.ToList();
            }
                return lista;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

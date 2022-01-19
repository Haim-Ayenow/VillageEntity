using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Village.Controllers.API
{
    public class CitizenController : ApiController
    {
        // GET: api/Citizen
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Citizen/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Citizen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Citizen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Citizen/5
        public void Delete(int id)
        {
        }
    }
}

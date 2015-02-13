using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Boomer.Server.Web.API.Controllers
{
    public class SecurityController : ApiController
    {
        // GET: api/Security
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Security/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Security
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Security/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Security/5
        public void Delete(int id)
        {
        }
    }
}

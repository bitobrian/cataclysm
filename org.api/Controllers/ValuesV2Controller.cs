using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Org.API.Controllers
{
    [Route("api/v2/values")]
    [ApiController]
    public class ValuesV2Controller : ControllerBase
    {
        // GET: api/ValuesV2
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "valuesv2 1", "valuesv2 2" };
        }

        // GET: api/ValuesV2/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "values v2 " + id.ToString();
        }

        // POST: api/ValuesV2
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ValuesV2/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

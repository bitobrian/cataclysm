using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace quiz.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        // GET api/Questions
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "question1", "question2" };
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "question " + id.ToString();
        }

        // POST api/questions
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/questions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/questions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

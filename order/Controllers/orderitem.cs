using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderitem : ControllerBase
    {
        // GET: api/<orderitem>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string []{"id:1","menuitemId:1","userId:1","name:phone"};
        }

        // GET api/<orderitem>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<orderitem>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<orderitem>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<orderitem>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

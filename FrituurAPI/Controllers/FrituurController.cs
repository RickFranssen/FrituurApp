using FrituurApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrituurAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrituurController : ControllerBase
    {
        // GET: api/<FrituurController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<FrituurController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Product.Read(id);
        }

        // POST api/<FrituurController>
        [HttpPost]
        public void Post([FromBody] string value) 
        {
        }

        // PUT api/<FrituurController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FrituurController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

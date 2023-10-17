using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebLayer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuickSortController : ControllerBase
    {
        // GET: api/<QuickSortController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QuickSortController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuickSortController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuickSortController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuickSortController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

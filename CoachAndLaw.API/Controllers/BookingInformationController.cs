using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoachAndLaw.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingInformationController : ControllerBase
    {
        // GET: api/<BookingInformationController>
        [HttpGet("get-bookings")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookingInformationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookingInformationController>
        [HttpPost("create-booking")]
        public IActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT api/<BookingInformationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingInformationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

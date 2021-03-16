using CoachAndLaw.Service;
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
    public class ServiceController : ControllerBase
    {
        // GET: api/<ServiceController>
        [HttpGet("get-services")]
        public IActionResult Get()
        {
            var serviceDataService = new ServiceDataService();
            try
            {
                var list = serviceDataService.GetServices();
                var obj = new
                {
                    statusCode = 200,
                    success = true,
                    data = list
                };

                return Ok(obj);
            }
            catch(Exception ex)
            {
                var obj = new
                {
                    statusCode = 404,
                    success = false,
                    errorMessage = "Services not found"
                };

                return BadRequest(obj);
            }
            
        }

        // GET api/<ServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

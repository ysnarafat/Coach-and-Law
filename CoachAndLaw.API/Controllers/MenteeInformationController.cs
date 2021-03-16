using CoachAndLaw.Models;
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
    public class MenteeInformationController : ControllerBase
    {
        private IMenteeInformationService _menteeInformationService;
        public MenteeInformationController(IMenteeInformationService menteeInformationService )
        {
            _menteeInformationService = menteeInformationService;
        }

        // GET: api/<MenteeInformationController>
        [HttpGet("get-mentee")]
        public IActionResult Get()
        {
            var list = _menteeInformationService.GetMenteeInformation();

            var result = new
            {
                statusCode = 200,
                success = true,
                data = list
            };
            //catch
            //{
            //    var erroResult = new
            //    {
            //        statusCode = 404,
            //        success = false,
            //        message = "Data not found"
            //    };

            //    return NotFound(erroResult);
            //}

            return Ok(result);
        }

        // GET api/<MenteeInformationController>/5
        [HttpGet("get-mentee-by-email")]
        public IActionResult Get([FromQuery] string email)
        {
            //var menteeeInformationService = new ManteeInformationService();
            var meneteeInforamation = _menteeInformationService.GetMenteeInformationByEmail(email);
            if(meneteeInforamation.Email != null)
            {
                var obj = new
                {
                    statusCode = 200,
                    success = true,
                    data = meneteeInforamation
                };

                return Ok(obj);
            }
            else
            {
                var obj = new
                {
                    statusCode = 404,
                    success = false,
                    erroMessage = "Mentee not found"
                };
                return BadRequest(obj);
            }
            
        }

        // POST api/<MenteeInformationController>
        [HttpPost("create-mentee")]
        public IActionResult Post([FromBody] MenteeInformationModel model)
        {
            if (model == null || !ModelState.IsValid)
            {
                return BadRequest(new
                {
                    statusCode = 101,
                    error = "Manual produced error"
                });
            }
            else
            {
                //var mentorInformationService = new ManteeInformationService();
                _menteeInformationService.CreateMentee(model);

                return Ok(new
                {
                    statusCode = 200,
                    success = true
                });
            }
        }

        // PUT api/<MenteeInformationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenteeInformationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

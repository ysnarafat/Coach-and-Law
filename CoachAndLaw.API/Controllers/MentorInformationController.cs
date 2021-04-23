using CoachAndLaw.Entity;
using CoachAndLaw.Model;
using CoachAndLaw.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace CoachAndLaw.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorInformationController : ControllerBase
    {
        // GET: api/<MentorInformationController>
        [HttpGet("get-mentors")]
        public IActionResult Get()
        {
            var mentorInforamtionService = new MentorInformationService();
            var result = mentorInforamtionService.GetMentorInformation();

            var obj = new
            {
                statusCode = 200,
                data = result,
                success = true
            };
            //return new HttpResponseMessage()
            //{
            //    Content = new StringContent(result, System.Text.Encoding.UTF8, "application/json")
            //}; ;

            return Ok(obj);
        }

        // GET api/<MentorInformationController>/5
        [HttpGet("get-mentor-by-email")]
        public IActionResult Get([FromQuery] string email)
        {
            var menteeeInformationService = new MentorInformationService();
            var meneteeInforamation = menteeeInformationService.GetMentorInformationByEmail(email);
            if (meneteeInforamation.Email != null)
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
                    erroMessage = "Mentor not found"
                };
                return BadRequest(obj);
            }
        }

        // POST api/<MentorInformationController>
        [HttpPost("create-mentor")]
        //[Produces("application/json")]
        public IActionResult Post(MentorInformationModel model)
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
                var mentorInformationService = new MentorInformationService();
                mentorInformationService.CreateMentorInformation(model);
                var mentor = mentorInformationService.GetNewMentor(model);

                return Ok(mentor);
            }
        }

        // PUT api/<MentorInformationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MentorInformationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

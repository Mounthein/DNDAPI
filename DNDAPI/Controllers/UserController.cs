using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }


        // GET api/<UserController>/5
        [Route("api/User/{id}/{pass}")]
        [HttpGet]
        public ActionResult Get(string id, string pass)
        {
            Missatge m = new Missatge();
            User u = userService.Get(id, pass);
            if (u == null)
            {
                m.Message = "Login Incorrect";
                var _json = JsonSerializer.Serialize(m);
                return NotFound(_json.ToString());
            }
            m.Message = "Login Correct";
            var json = JsonSerializer.Serialize(m);
            return Ok(json.ToString());
        }

        // POST api/<UserController>
        [Route("api/User")]
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            Missatge m = new Missatge();
            User u = new User();
            try
            {
                u = userService.Get(user.UserName);
            } catch (Exception ex)
            {

            }
            
            if (u != null && u.UserName.Equals(user.UserName))
            {
                m.Message = "User alredy exists";
                var _jso = JsonSerializer.Serialize(m);
                return NotFound(_jso.ToString());
            }
            userService.Create(user);

            m.Message = "Register Correct";
            var _json = JsonSerializer.Serialize(m);
            return Ok(_json.ToString());
        }

        // PUT api/<UserController>/5
        [Route("api/User/{id}/{check}")]
        [HttpPut]
        public ActionResult Put(string id, [FromBody] User user, string check)
        {
            User u = userService.Get(user.Id);
            if (u == null)
            {
                return NotFound("User does no exists");
            }
            userService.Update(id, user, check);

            return Ok("Update Correct");
        }

        // DELETE api/<UserController>/5
        [Route("api/User/{id}/{check}")]
        [HttpDelete]
        public ActionResult Delete(string id, string check)
        {
            User u = userService.Get(id);
            if (u == null)
            {
                return NotFound("User does no exists");
            }
            userService.Remove(id, check);

            return Ok("Deleted Correctly");
        }
    }
}

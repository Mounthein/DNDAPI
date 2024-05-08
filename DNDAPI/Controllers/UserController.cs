using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

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
            User u = userService.Get(id, pass);
            if (u == null)
            {
                return NotFound("Login Incorrect");
            }
            return Ok("Login Correct");
        }

        // POST api/<UserController>
        [Route("api/User")]
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            User u = new User();
            try
            {
                u = userService.Get(user.Id);
            } catch (Exception ex)
            {

            }
            
            if (u != null && u.UserName.Equals(user.UserName))
            {
                return NotFound("User alredy exists");
            }
            userService.Create(user);

            return Ok("Register Correct");
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

using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubraceController : ControllerBase
    {
        private readonly ISubraceService subraceService;
        public SubraceController(ISubraceService subraceService)
        {
            this.subraceService = subraceService;
        }

        // GET: api/<SubraceController>
        [HttpGet]
        public ActionResult<List<Subrace>> Get()
        {
            return subraceService.Get();
        }

        // GET api/<SubraceController>/5
        [HttpGet("{id}")]
        public ActionResult<Subrace> Get(string id)
        {
            return subraceService.Get(id);
        }

        // POST api/<SubraceController>
        [HttpPost]
        public ActionResult<Subrace> Post([FromBody] Subrace subrace)
        {
            subraceService.Create(subrace);

            return CreatedAtAction(nameof(Get), new { id =  subrace.Id }, subrace);
        }

        // PUT api/<SubraceController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Subrace subrace)
        {
            var existingSubrace = subraceService.Get(id);

            if (existingSubrace == null)
            {
                return NotFound($"Subrace with Id = {id} not found");
            }

            subraceService.Update(id, subrace);

            return NoContent();
        }

        // DELETE api/<SubraceController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var subrace = subraceService.Get(id);

            if (subrace == null)
            {
                return NotFound($"Subrace with Id = {id} not found");
            }

            subraceService.Remove(subrace.Id);

            return Ok($"Subrace with Id = {id} not found");
        }
    }
}

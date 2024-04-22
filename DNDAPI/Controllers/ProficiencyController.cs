using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProficiencyController : ControllerBase
    {
        private readonly IProficiencyService proficiencyService;
        public ProficiencyController(IProficiencyService proficiencyService)
        {
            this.proficiencyService = proficiencyService;
        }

        // GET: api/<ProficiencyController>
        [HttpGet]
        public ActionResult<List<Proficiency>> Get()
        {
            return proficiencyService.Get();
        }

        // GET api/<ProficiencyController>/5
        [HttpGet("{id}")]
        public ActionResult<Proficiency> Get(string id)
        {
            return proficiencyService.Get(id);
        }

        // POST api/<ProficiencyController>
        [HttpPost]
        public ActionResult<Proficiency> Post([FromBody] Proficiency proficiency)
        {
            proficiencyService.Create(proficiency);

            return CreatedAtAction(nameof(Get), new { id = proficiency.Id }, proficiency);
        }

        // PUT api/<ProficiencyController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Proficiency proficiency)
        {
            var existingProficiency = proficiencyService.Get(id);

            if (existingProficiency == null)
            {
                return NotFound($"Proficiency with Id = {id} not found");
            }

            proficiencyService.Update(id, existingProficiency);

            return NoContent();
        }

        // DELETE api/<ProficiencyController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var proficiency = proficiencyService.Get(id);

            if (proficiency == null)
            {
                return NotFound($"Proficiency with Id = {id} not found");
            }

            proficiencyService.Remove(proficiency.Id);

            return Ok($"Proficiency with Id = {id} deleted");
        }
    }
}

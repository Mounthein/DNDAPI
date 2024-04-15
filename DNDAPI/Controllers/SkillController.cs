using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService skillService;
        public SkillController(ISkillService skillService)
        {
            this.skillService = skillService;
        }


        // GET: api/<SkillController>
        [HttpGet]
        public ActionResult<List<Skill>> Get()
        {
            return skillService.Get();
        }

        // GET api/<SkillController>/5
        [HttpGet("{id}")]
        public ActionResult<Skill> Get(string id)
        {
            return skillService.Get(id);
        }

        // POST api/<SkillController>
        [HttpPost]
        public ActionResult<Skill> Post([FromBody] Skill skill)
        {
            skillService.Create(skill);

            return CreatedAtAction(nameof(Get), new { id = skill.Id }, skill);
        }

        // PUT api/<SkillController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Skill skill)
        {
            var existingSkill = skillService.Get(id);

            if (existingSkill == null)
            {
                return NotFound($"Skill with Id = {id} not found");
            }

            skillService.Update(id, skill);

            return NoContent();
        }

        // DELETE api/<SkillController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var existingSkill = skillService.Get(id);

            if (existingSkill == null)
            {
                return NotFound($"Skill with Id = {id} not found");
            }

            skillService.Remove(existingSkill.Id);

            return Ok($"Skill with Id = {id} deleted");
        }
    }
}

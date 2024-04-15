using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbilityScoreController : ControllerBase
    {
        private readonly IAbilityScoreService abilityScoreService;
        public AbilityScoreController(IAbilityScoreService abilityScoreService)
        {
            this.abilityScoreService = abilityScoreService;
        }

        // GET: api/<AbilityScoreController>
        [HttpGet]
        public ActionResult<List<AbilityScore>> Get()
        {
            return abilityScoreService.Get();
        }

        // GET api/<AbilityScoreController>/5
        [HttpGet("{id}")]
        public AbilityScore Get(string id)
        {
            return abilityScoreService.Get(id);
        }

        // POST api/<AbilityScoreController>
        [HttpPost]
        public ActionResult<AbilityScore> Post([FromBody] AbilityScore score)
        {
            abilityScoreService.Create(score);

            return CreatedAtAction(nameof(Get), new { id = score.Id }, score);
        }

        // PUT api/<AbilityScoreController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] AbilityScore score)
        {
            var existingAbilityScore = abilityScoreService.Get(id);

            if (existingAbilityScore == null)
            {
                return NotFound($"Ability Score with Is = {id} not found");
            }

            abilityScoreService.Update(id, score);

            return NoContent();
        }

        // DELETE api/<AbilityScoreController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var score = abilityScoreService.Get(id);

            if (score == null)
            {
                return NotFound($"Ability Score with Id = {id} not found");
            }

            abilityScoreService.Remove(score.Id);

            return Ok($"Ability Score with Id = {id} deleted");
        }
    }
}

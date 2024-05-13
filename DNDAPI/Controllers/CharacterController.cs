using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService characterService;

        public CharacterController(ICharacterService characterService)
        {
                this.characterService = characterService;
        }

        // GET: api/<CharacterController>
        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return characterService.Get();
        }

        // GET api/<CharacterController>/5
        [HttpGet("{id}")]
        public ActionResult<Character> Get(string id)
        {
            return characterService.Get(id);
        }

        // POST api/<CharacterController>
        [HttpPost]
        public ActionResult<Character> Post([FromBody] Character character)
        {
            characterService.Create(character);

            return CreatedAtAction(nameof(Get), new { id = character.Id }, character);
        }

        // PUT api/<CharacterController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Character character)
        {
            var existingBackground = characterService.Get(id);

            if (existingBackground == null)
            {
                return NotFound($"Character with Id = {id} not found");
            }

            characterService.Update(id, existingBackground);

            return NoContent();
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var background = characterService.Get(id);

            if (background == null)
            {
                return NotFound($"Character with Id = {id} not found");
            }

            characterService.Remove(background.Id);

            return Ok($"Character with Id = {id} deleted");
        }
    }
}

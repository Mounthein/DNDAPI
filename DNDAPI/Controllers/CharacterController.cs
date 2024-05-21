using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace DNDAPI.Controllers
{
    //[Route("")]
    //[ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService characterService;

        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }

        // GET: api/<CharacterController>
        [Route("api/Get")]
        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return characterService.Get();
        }

        // GET api/<CharacterController>/5
        [Route("api/Get/{id}")]
        [HttpGet]
        public ActionResult<Character> Get(string id)
        {
            return characterService.Get(id);
        }

        //GET api/<CharacterController>/5
        [Route("api/GetByUserName/{user}")]
        [HttpGet]
        public ActionResult<List<Character>> GetByUserName(string user)
        {
            return characterService.GetByUserName(user);
        }

        // POST api/<CharacterController>
        [Route("api/Post")]
        [HttpPost]
        public ActionResult<Character> Post([FromBody] Character character)
        {
            characterService.Create(character);

            return CreatedAtAction(nameof(Get), new { id = character.Id }, character);
        }

        // PUT api/<CharacterController>/5
        [Route("api/Put")]
        [HttpPut]
        public ActionResult Put(string id, [FromBody] Character character)
        {
            var existingCharacter = characterService.Get(id);

            if (existingCharacter == null)
            {
                return NotFound($"Character with Id = {id} not found");
            }

            characterService.Update(id, existingCharacter);

            return NoContent();
        }

        // DELETE api/<CharacterController>/5
        [Route("api/Delete/{id}")]
        [HttpDelete]
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

using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService levelService;
        public LevelController(ILevelService levelService)
        {
            this.levelService = levelService;
        }

        // GET: api/<LevelController>
        [HttpGet]
        public ActionResult<List<Level>> Get()
        {
            return levelService.Get();
        }

        // GET api/<LevelController>/5
        [HttpGet("{id}")]
        public ActionResult<Level> Get(string id)
        {
            return levelService.Get(id);
        }

        // POST api/<LevelController>
        [HttpPost]
        public ActionResult<Level> Post([FromBody] Level level)
        {
            levelService.Create(level);

            return CreatedAtAction(nameof(Get), new { id = level.Id }, level);
        }

        // PUT api/<LevelController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Level level)
        {
            var existingLevel = levelService.Get(id);

            if (existingLevel == null)
            {
                return NotFound($"Level with Id = {id} not found");
            }

            levelService.Update(id, level);

            return NoContent();
        }

        // DELETE api/<LevelController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var level = levelService.Get(id);

            if (level == null)
            {
                return NotFound($"Level with Id = {id} not found");
            }

            levelService.Remove(level.Id);

            return Ok($"Level with Id = {id} deleted");
        }
    }
}

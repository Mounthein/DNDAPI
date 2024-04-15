using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BackgroundController : ControllerBase
    {
        private readonly IBackgroundService backgroundService;
        public BackgroundController(IBackgroundService backgroundService)
        {
            this.backgroundService = backgroundService;
        }

        // GET: api/<BackgroundController>
        [HttpGet]
        public ActionResult<List<Background>> Get()
        {
            return backgroundService.Get();
        }

        // GET api/<BackgroundController>/5
        [HttpGet("{id}")]
        public ActionResult<Background> Get(string id)
        {
            return backgroundService.Get(id);
        }

        // POST api/<BackgroundController>
        [HttpPost]
        public ActionResult<Background> Post([FromBody] Background background)
        {
            backgroundService.Create(background);

            return CreatedAtAction(nameof(Get), new { id = background.Id }, background);
        }

        // PUT api/<BackgroundController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Background background)
        {
            var existingBackground = backgroundService.Get(id);

            if (existingBackground == null)
            {
                return NotFound($"Background with Id = {id} not found");
            }

            backgroundService.Update(id, existingBackground);

            return NoContent();
        }

        // DELETE api/<BackgroundController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var background = backgroundService.Get(id);

            if (background == null)
            {
                return NotFound($"Background with Id = {id} not found");
            }

            backgroundService.Remove(background.Id);

            return Ok($"Background with Id = {id} deleted");
        }
    }
}

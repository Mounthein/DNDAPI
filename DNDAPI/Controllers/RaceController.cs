using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService raceService;
        public RaceController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        // GET: api/<RaceController>
        [HttpGet]
        public ActionResult<List<Race>> Get()
        {
            return raceService.Get();
        }

        // GET api/<RaceController>/5
        [HttpGet("{id}")]
        public ActionResult<Race> Get(string id)
        {
            return raceService.Get(id);
        }

        // POST api/<RaceController>
        [HttpPost]
        public ActionResult<Race> Post([FromBody] Race race)
        {
            raceService.Create(race);

            return CreatedAtAction(nameof(Get), new { id = race.Id }, race);
        }

        // PUT api/<RaceController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Race race)
        {
            var existingRace = raceService.Get(id);

            if (existingRace == null)
            {
                return NotFound($"Race with Id = {id} not found");
            }

            raceService.Update(id, race);

            return NoContent();
        }

        // DELETE api/<RaceController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var race = raceService.Get(id);

            if (race == null)
            {
                return NotFound($"Race with Id = {id} not found");
            }

            raceService.Remove(race.Id);

            return Ok($"Race with Id = {id} deleted");
        }
    }
}

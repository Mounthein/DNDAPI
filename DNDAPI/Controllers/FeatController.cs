using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatController : ControllerBase
    {
        private readonly IFeatService featService;
        public FeatController(IFeatService featService)
        {
            this.featService = featService;
        }

        // GET: api/<FeatController>
        [HttpGet]
        public ActionResult<List<Feat>> Get()
        {
            return featService.Get();
        }

        // GET api/<FeatController>/5
        [HttpGet("{id}")]
        public ActionResult<Feat> Get(string id)
        {
            return featService.Get(id);
        }

        // POST api/<FeatController>
        [HttpPost]
        public ActionResult<Feat> Post([FromBody] Feat feat)
        {
            featService.Create(feat);

            return CreatedAtAction(nameof(Get), new { id = feat.Id }, feat);
        }

        // PUT api/<FeatController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Feat feat)
        {
            var existingFeat = featService.Get(id);

            if (existingFeat == null)
            {
                return NotFound($"Feat with Id = {id} not found");
            }

            featService.Update(id, feat);

            return NoContent();
        }

        // DELETE api/<FeatController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var feat = featService.Get(id);

            if(feat == null)
            {
                return NotFound($"Feat with Id = {id} not found");
            }

            featService.Remove(feat.Id);

            return Ok($"Feat with Id = {id} deleted");
        }
    }
}

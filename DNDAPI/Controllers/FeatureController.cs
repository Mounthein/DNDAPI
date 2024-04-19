using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService featureService;
        public FeatureController(IFeatureService featureService)
        {
            this.featureService = featureService;
        }

        // GET: api/<FeatureController>
        [HttpGet]
        public ActionResult<List<Feature>> Get()
        {
            return featureService.Get();
        }

        // GET api/<FeatureController>/5
        [HttpGet("{id}")]
        public ActionResult<Feature> Get(string id)
        {
            return featureService.Get(id);
        }

        // POST api/<FeatureController>
        [HttpPost]
        public ActionResult<Feature> Post([FromBody] Feature feature)
        {
            featureService.Create(feature);

            return CreatedAtAction(nameof(Get), new { id = feature.Id }, feature);
        }

        // PUT api/<FeatureController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Feature feature)
        {
            var existingFeature = featureService.Get(id);

            if (existingFeature == null)
            {
                return NotFound($"Feature with Id = {id} not found");
            }

            featureService.Update(id, feature);

            return NoContent();
        }

        // DELETE api/<FeatureController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var feature = featureService.Get(id);

            if (feature == null)
            {
                return NotFound($"Feature with Id = {id} not found");
            }

            featureService.Remove(feature.Id);

            return Ok($"Feature with Id = {id} deleted");
        }
    }
}

using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraitController : ControllerBase
    {
        private readonly ITraitService traitService;
        public TraitController(ITraitService trait)
        {
            this.traitService = trait;
        }

        // GET: api/<TraitController>
        [HttpGet]
        public ActionResult<List<Trait>> Get()
        {
            return traitService.Get();
        }

        // GET api/<TraitController>/5
        [HttpGet("{id}")]
        public ActionResult<Trait> Get(string id)
        {
            return traitService.Get(id);
        }

        // POST api/<TraitController>
        [HttpPost]
        public ActionResult<Trait> Post([FromBody] Trait trait)
        {
            traitService.Create(trait);

            return CreatedAtAction(nameof(Get), new { id = trait.Id }, trait);
        }

        // PUT api/<TraitController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Trait trait)
        {
            var existingTrait = traitService.Get(id);

            if (existingTrait == null)
            {
                return NotFound($"Trait with Id = {id} not found");
            }

            traitService.Update(id, trait);

            return NoContent();
        }

        // DELETE api/<TraitController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var trait = traitService.Get(id);

            if (trait == null)
            {
                return NotFound($"Trait with Id = {id} not found");
            }

            traitService.Remove(trait.Id);

            return Ok($"Trait with Id = {id} deleted");
        }
    }
}

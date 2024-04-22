using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellController : ControllerBase
    {
        private readonly ISpellService spellService;
        public SpellController(ISpellService spellService)
        {
            this.spellService = spellService;
        }

        // GET: api/<SpellController>
        [HttpGet]
        public ActionResult<List<Spell>> Get()
        {
            return spellService.Get();
        }

        // GET api/<SpellController>/5
        [HttpGet("{id}")]
        public ActionResult<Spell> Get(string id)
        {
            return spellService.Get(id);
        }

        // POST api/<SpellController>
        [HttpPost]
        public ActionResult<Spell> Post([FromBody] Spell spell)
        {
            spellService.Create(spell);

            return CreatedAtAction(nameof(Get), new { id = spell.Id }, spell);
        }

        // PUT api/<SpellController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Spell spell)
        {
            var existingSpell = spellService.Get(id);

            if (existingSpell == null)
            {
                return NotFound($"Spell with Id = {id} not found");
            }

            spellService.Update(id, spell);

            return NoContent();
        }

        // DELETE api/<SpellController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var spell = spellService.Get(id);

            if (spell == null)
            {
                return NotFound($"Spell with Id = {id} not found");
            }

            spellService.Remove(id);

            return Ok($"Spell with Id = {id} deleted");
        }
    }
}

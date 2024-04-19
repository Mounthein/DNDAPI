using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicItemController : ControllerBase
    {
        private readonly IMagicItemService magicItemService;
        public MagicItemController(IMagicItemService magicItemService)
        {
            this.magicItemService = magicItemService;
        }

        // GET: api/<MagicItemController>
        [HttpGet]
        public ActionResult<List<MagicItem>> Get()
        {
            return magicItemService.Get();
        }

        // GET api/<MagicItemController>/5
        [HttpGet("{id}")]
        public ActionResult<MagicItem> Get(string id)
        {
            return magicItemService.Get(id);
        }

        // POST api/<MagicItemController>
        [HttpPost]
        public ActionResult<MagicItem> Post([FromBody] MagicItem magicItem)
        {
            magicItemService.Create(magicItem);

            return CreatedAtAction(nameof(MagicItem), new { id = magicItem.Id }, magicItem);
        }

        // PUT api/<MagicItemController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] MagicItem magicItem)
        {
            var existingMagicItem = magicItemService.Get(id);

            if (existingMagicItem == null)
            {
                return NotFound($"Magic Item with Id = {id} not found");
            }

            magicItemService.Update(id, magicItem);

            return NoContent();
        }

        // DELETE api/<MagicItemController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var magicItem = magicItemService.Get(id);

            if (magicItem == null)
            {
                return NotFound($"Magic Item with Id = {id} not found");
            }

            magicItemService.Remove(magicItem.Id);

            return Ok($"Magic Item with Id = {id} deleted");
        }
    }
}

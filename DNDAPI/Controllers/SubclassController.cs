using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubclassController : ControllerBase
    {
        private readonly ISubclassService subclassService;
        public SubclassController(ISubclassService subclassService)
        {
            this.subclassService = subclassService;
        }

        // GET: api/<SubclassController>
        [HttpGet]
        public ActionResult<List<Subclass>> Get()
        {
            return subclassService.Get();
        }

        // GET api/<SubclassController>/5
        [HttpGet("{id}")]
        public ActionResult<Subclass> Get(string id)
        {
            return subclassService.Get(id);
        }

        // POST api/<SubclassController>
        [HttpPost]
        public ActionResult Post([FromBody] Subclass subclass)
        {
            subclassService.Create(subclass);

            return CreatedAtAction(nameof(Get), new { id = subclass.Id }, subclass);
        }

        // PUT api/<SubclassController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Subclass subclass)
        {
            var existingSubclass = subclassService.Get(id);

            if (existingSubclass == null)
            {
                return NotFound($"Subclass with Id = {id} not found");
            }

            subclassService.Update(id, existingSubclass);

            return NoContent();
        }

        // DELETE api/<SubclassController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var subclass = subclassService.Get(id);

            if (subclass == null)
            {
                return NotFound($"Subclass with Id = {id} not found");
            }

            subclassService.Remove(subclass.Id);

            return Ok($"Subclass with id = {id} deleted");
        }
    }
}

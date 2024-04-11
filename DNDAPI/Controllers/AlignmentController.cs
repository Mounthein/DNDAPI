using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlignmentController : ControllerBase
    {
        private readonly IAlignmentService alignmentService;

        public AlignmentController(IAlignmentService alignmentService)
        {
            this.alignmentService = alignmentService;
        }
        // GET: api/<AlignmentController>
        [HttpGet]
        public ActionResult<List<Alignment>> Get()
        {
            return alignmentService.Get();
        }

        // GET api/<AlignmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Alignment> Get(string id)
        {
            return alignmentService.Get(id);
        }

        // POST api/<AlignmentController>
        [HttpPost]
        public ActionResult<Alignment> Post([FromBody] Alignment alignment)
        {
            alignmentService.Create(alignment);

            return alignment;
        }

        // PUT api/<AlignmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Alignment alignment)
        {
            var existingAlignment = alignmentService.Get(id);

            if (existingAlignment == null)
            {
                return NotFound($"Alignment with Id = {id} not found");
            }

            alignmentService.Update(id, alignment);

            return NoContent();
        }

        // DELETE api/<AlignmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var alignement = alignmentService.Get(id);

            if(alignement == null)
            {
                return NotFound($"Alignment with Id = {id} not found");
            }

            alignmentService.Remove(alignement.Id);

            return Ok($"Alignment with Id = {id} deleted");
        }
    }
}

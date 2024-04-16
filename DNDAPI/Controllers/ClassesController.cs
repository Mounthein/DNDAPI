using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassesService classesService;
        public ClassesController(IClassesService classesService)
        {
            this.classesService = classesService;
        }

        // GET: api/<ClassesController>
        [HttpGet]
        public ActionResult<List<Classes>> Get()
        {
            return classesService.Get(); ;
        }

        // GET api/<ClassesController>/5
        [HttpGet("{id}")]
        public ActionResult<Classes> Get(string id)
        {
            return classesService.Get(id);
        }

        // POST api/<ClassesController>
        [HttpPost]
        public ActionResult<Classes> Post([FromBody] Classes classes)
        {
            classesService.Create(classes);

            return CreatedAtAction(nameof(Get), new { id = classes.Id }, classes);
        }

        // PUT api/<ClassesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Classes classes)
        {
            var existingClass = classesService.Get(id);

            if (existingClass == null)
            {
                return NotFound($"Class with Id = {id} not found");
            }

            classesService.Update(id, classes);

            return NoContent();
        }

        // DELETE api/<ClassesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var classes = classesService.Get(id);

            if (classes == null)
            {
                return NotFound($"Class with Id = {id} not found");
            }

            classesService.Remove(classes.Id);

            return Ok($"Class with Id = {id} deleted");
        }
    }
}

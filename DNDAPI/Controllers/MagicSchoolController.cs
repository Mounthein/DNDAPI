using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicSchoolController : ControllerBase
    {
        private readonly IMagicSchoolService magicSchoolService;
        public MagicSchoolController(IMagicSchoolService magicSchoolService)
        {
            this.magicSchoolService = magicSchoolService;
        }

        // GET: api/<MagicSchoolController>
        [HttpGet]
        public ActionResult<List<MagicSchool>> Get()
        {
            return magicSchoolService.Get();
        }

        // GET api/<MagicSchoolController>/5
        [HttpGet("{id}")]
        public ActionResult<MagicSchool> Get(string id)
        {
            return magicSchoolService.Get(id);
        }

        // POST api/<MagicSchoolController>
        [HttpPost]
        public ActionResult<MagicSchool> Post([FromBody] MagicSchool magicSchool)
        {
            magicSchoolService.Create(magicSchool);

            return CreatedAtAction(nameof(Get), new { id = magicSchool.Id}, magicSchool);
        }

        // PUT api/<MagicSchoolController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] MagicSchool magicSchool)
        {
            var existingMagicSchool = magicSchoolService.Get(id);

            if (existingMagicSchool == null)
            {
                return NotFound($"Magic School with Id = {id} not found");
            }

            magicSchoolService.Update(id, magicSchool);

            return NoContent();
        }

        // DELETE api/<MagicSchoolController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var magicSchool = magicSchoolService.Get(id);

            if (magicSchool == null)
            {
                return NotFound($"Magic School with Id = {id} not found");
            }

            magicSchoolService.Remove(magicSchool.Id);

            return Ok($"Magic School with Id = {id} deleted");
        }
    }
}

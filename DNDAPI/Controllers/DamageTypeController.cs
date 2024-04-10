using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DamageTypeController : ControllerBase
    {
        private readonly IDamageTypeService damageTypeService;
        public DamageTypeController(IDamageTypeService damageTypeService)
        {
            this.damageTypeService = damageTypeService;
        }

        // GET: api/<DamageTypeController>
        [HttpGet]
        public ActionResult<List<DamageType>> Get()
        {
            return damageTypeService.Get();
        }

        // GET api/<DamageTypeController>/5
        [HttpGet("{id}")]
        public ActionResult<DamageType> Get(string id)
        {
            return damageTypeService.Get(id);
        }

        // POST api/<DamageTypeController>
        [HttpPost]
        public ActionResult<DamageType> Post([FromBody] DamageType damageType)
        {
            damageTypeService.Create(damageType);

            return CreatedAtAction(nameof(Get), new { id = damageType.Id}, damageType);
        }

        // PUT api/<DamageTypeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] DamageType damageType)
        {
            var existingDamageType = damageTypeService.Get(id);

            if (existingDamageType == null)
            {
                return NotFound($"Damage Type with Id = {id} not found");
            }

            damageTypeService.Update(id, damageType);

            return NoContent();
        }

        // DELETE api/<DamageTypeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var damageType = damageTypeService.Get(id);

            if (damageType == null)
            {
                return NotFound($"Damage Type with Id = {id} not found");
            }

            damageTypeService.Remove(damageType.Id);

            return Ok($"Student with Id = {id} deleted");
        }
    }
}

using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponPropertyController : ControllerBase
    {
        private readonly IWeaponPropertyService weaponPropertyService;

        public WeaponPropertyController(IWeaponPropertyService weaponPropertyService)
        {
            this.weaponPropertyService = weaponPropertyService;
        }

        // GET: api/<WeaponPropertyController>
        [HttpGet]
        public ActionResult<List<WeaponProperty>> Get()
        {
            return weaponPropertyService.Get();
        }

        // GET api/<WeaponPropertyController>/5
        [HttpGet("{id}")]
        public ActionResult<WeaponProperty> Get(string id)
        {
            return weaponPropertyService.Get(id);
        }

        // POST api/<WeaponPropertyController>
        [HttpPost]
        public ActionResult<WeaponProperty> Post([FromBody] WeaponProperty property)
        {
            weaponPropertyService.Create(property);

            return CreatedAtAction(nameof(Get), new { id = property.Id }, property);
        }

        // PUT api/<WeaponPropertyController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] WeaponProperty property)
        {
            var existingProperty = weaponPropertyService.Get(id);

            if (existingProperty == null)
            {
                return NotFound($"Weapon property with Id = {id} not found");
            }

            weaponPropertyService.Update(id, property);

            return NoContent();
        }

        // DELETE api/<WeaponPropertyController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var property = weaponPropertyService.Get(id);

            if (property == null)
            {
                return NotFound($"Weapon property with Id = {id} not found");
            }

            weaponPropertyService.Remove(property.Id);

            return NoContent();
        }
    }
}

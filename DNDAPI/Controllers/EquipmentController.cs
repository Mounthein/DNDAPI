using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService equipmentService;
        public EquipmentController(IEquipmentService equipmentService)
        {
            this.equipmentService = equipmentService;
        }

        // GET: api/<EquipmentController>
        [HttpGet]
        public ActionResult<List<Equipment>> Get()
        {
            return equipmentService.Get();
        }

        // GET api/<EquipmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Equipment> Get(string id)
        {
            return equipmentService.Get(id);
        }

        // POST api/<EquipmentController>
        [HttpPost]
        public ActionResult<Equipment> Post([FromBody] Equipment equipment)
        {
            equipmentService.Create(equipment);

            return CreatedAtAction(nameof(Get), new { id =  equipment.Id }, equipment);
        }

        // PUT api/<EquipmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Equipment equipment)
        {
            var existingEquipment = equipmentService.Get(id);

            if (existingEquipment == null)
            {
                return NotFound($"Equipment with Id = {id} not found");
            }

            equipmentService.Update(id, equipment);

            return NoContent();
        }

        // DELETE api/<EquipmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var equipment = equipmentService.Get( id);

            if (equipment == null)
            {
                return NotFound($"Equipment with Id = {id} not found");
            }

            equipmentService.Remove(equipment.Id);

            return Ok($"Equipment with Id = {id} deleted");
        }
    }
}

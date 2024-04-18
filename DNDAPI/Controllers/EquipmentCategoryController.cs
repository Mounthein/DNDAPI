using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentCategoryController : ControllerBase
    {
        private readonly IEquipmentCategoryService equipmentCategoryService;
        public EquipmentCategoryController(IEquipmentCategoryService equipmentCategoryService)
        {
            this.equipmentCategoryService = equipmentCategoryService;
        }

        // GET: api/<EquipmentCategoryController>
        [HttpGet]
        public ActionResult<List<EquipmentCategory>> Get()
        {
            return equipmentCategoryService.Get();
        }

        // GET api/<EquipmentCategoryController>/5
        [HttpGet("{id}")]
        public ActionResult<EquipmentCategory> Get(string id)
        {
            return equipmentCategoryService.Get(id);
        }

        // POST api/<EquipmentCategoryController>
        [HttpPost]
        public ActionResult<EquipmentCategory> Post([FromBody] EquipmentCategory equipmentCategory)
        {
            equipmentCategoryService.Create(equipmentCategory);

            return CreatedAtAction(nameof(Get), new { id = equipmentCategory.Id }, equipmentCategory);
        }

        // PUT api/<EquipmentCategoryController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] EquipmentCategory equipmentCategory)
        {
            var existingEquipmentCategory = equipmentCategoryService.Get(id);

            if (existingEquipmentCategory == null)
            {
                return NotFound($"Equipment Category with Id = {id} not found");
            }

            equipmentCategoryService.Update(id, equipmentCategory);

            return NoContent();
        }

        // DELETE api/<EquipmentCategoryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var equipmentCategory = equipmentCategoryService.Get(id);

            if (equipmentCategory == null)
            {
                return NotFound($"Equipment Category with Id = {id} not found");
            }

            equipmentCategoryService.Remove(equipmentCategory.Id);

            return Ok($"Equipment Catgory with Id = {id} deleted");
        }
    }
}

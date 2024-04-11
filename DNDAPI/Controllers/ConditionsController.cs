using Amazon.Auth.AccessControlPolicy;
using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConditionsController : ControllerBase
    {
        private readonly IConditionService conditionService;

        public ConditionsController(IConditionService conditionService)
        {
            this.conditionService = conditionService;
        }

        // GET: api/<ConditionsController>
        [HttpGet]
        public ActionResult<List<Conditions>> Get()
        {
            return conditionService.Get();
        }

        // GET api/<ConditionsController>/5
        [HttpGet("{id}")]
        public ActionResult<Conditions> Get(string id)
        {
            return conditionService.Get(id);
        }

        // POST api/<ConditionsController>
        [HttpPost]
        public ActionResult<Conditions> Post([FromBody] Conditions conditions)
        {
            conditionService.Create(conditions);

            return CreatedAtAction(nameof(Get), new { id = conditions.Id }, conditions);
        }

        // PUT api/<ConditionsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Conditions condition)
        {
            var existingCondition = conditionService.Get(id);

            if (existingCondition == null)
            {
                return NotFound($"Damage Type with Id = {id} not found");
            }

            conditionService.Update(id, condition);

            return NoContent();
        }

        // DELETE api/<ConditionsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var condition = conditionService.Get(id);

            if (condition == null)
            {
                return NotFound($"Condition with Id = {id} not found");
            }

            conditionService.Remove(condition.Id);

            return Ok($"Condition with Id = {id} deleted");
        }
    }
}

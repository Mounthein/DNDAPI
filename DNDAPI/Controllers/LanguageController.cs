using DNDAPI.Models;
using DNDAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DNDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService languageService;
        public LanguageController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }


        // GET: api/<LanguageController>
        [HttpGet]
        public ActionResult<List<Language>> Get()
        {
            return languageService.Get();
        }

        // GET api/<LanguageController>/5
        [HttpGet("{id}")]
        public ActionResult<Language> Get(string id)
        {
            return languageService.Get(id);
        }

        // POST api/<LanguageController>
        [HttpPost]
        public ActionResult<Language> Post([FromBody] Language language)
        {
            languageService.Create(language);

            return CreatedAtAction(nameof(Get), new { id = language.Id }, language);
        }

        // PUT api/<LanguageController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Language language)
        {
            var existingLanguage = languageService.Get(id);

            if (existingLanguage == null)
            {
                return NotFound($"Language with Id = {id} not found");
            }

            languageService.Update(id, language);

            return NoContent();
        }

        // DELETE api/<LanguageController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var language = languageService.Get(id);

            if (language == null)
            {
                return NotFound($"Language with Id = {id} not found");
            }

            languageService.Remove(language.Id);

            return Ok($"Language Type with Id = {id} deleted");
        }
    }
}

using DNDAPI.Models;
using System.Reflection.Metadata;

namespace DNDAPI.Services
{
    public interface ILanguageService
    {
        List<Language> Get();
        Language Get(string id);
        Language Create(Language language);
        void Update(string id, Language language);
        void Remove(string id);
    }
}

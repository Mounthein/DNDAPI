using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IMongoCollection<Language> _languages;

        public LanguageService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _languages = database.GetCollection<Language>(settings.DndLanguageCollectionName);
        }
        public Language Create(Language language)
        {
            _languages.InsertOne(language);
            return language;
        }

        public List<Language> Get()
        {
            return _languages.Find(language => true).ToList();
        }

        public Language Get(string id)
        {
            return _languages.Find(language => language.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _languages.DeleteOne(language => language.Id == id);
        }

        public void Update(string id, Language language)
        {
            _languages.ReplaceOne(language => language.Id == id, language);
        }
    }
}

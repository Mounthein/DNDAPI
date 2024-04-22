using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class ProficiencyService : IProficiencyService
    {
        private readonly IMongoCollection<Proficiency> _profiles;

        public ProficiencyService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _profiles = database.GetCollection<Proficiency>(settings.DndProficiencyCollectionName);
        }
        public Proficiency Create(Proficiency proficiency)
        {
            _profiles.InsertOne(proficiency);
            return proficiency;
        }

        public List<Proficiency> Get()
        {
            return _profiles.Find(proficienty => true).ToList();
        }

        public Proficiency Get(string id)
        {
            return _profiles.Find(proficienty => proficienty.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _profiles.DeleteOne(proficiency => proficiency.Id == id);
        }

        public void Update(string id, Proficiency proficiency)
        {
            _profiles.ReplaceOne(proficienty => proficiency.Id == id, proficiency);
        }
    }
}

using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class AbilityScoreService : IAbilityScoreService
    {
        private readonly IMongoCollection<AbilityScore> _abilities;

        public AbilityScoreService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _abilities = database.GetCollection<AbilityScore>(settings.DndAbilityScoreCollectionName);
        }
        public AbilityScore Create(AbilityScore score)
        {
            _abilities.InsertOne(score);
            return score;
        }

        public List<AbilityScore> Get()
        {
            return _abilities.Find(ability => true).ToList();
        }

        public AbilityScore Get(string id)
        {
            return _abilities.Find(ability => ability.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _abilities.DeleteOne(ability => ability.Id == id);
        }

        public void Update(string id, AbilityScore score)
        {
            _abilities.ReplaceOne(ability => ability.Id == id, score);
        }
    }
}

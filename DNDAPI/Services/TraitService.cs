using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class TraitService : ITraitService
    {
        private IMongoCollection<Trait> _traits;
        
        public TraitService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _traits = database.GetCollection<Trait>(settings.DndTraitCollectionName);
        }
        public Trait Create(Trait trait)
        {
            _traits.InsertOne(trait);
            return trait;
        }

        public List<Trait> Get()
        {
            return _traits.Find(trait => true).ToList();
        }

        public Trait Get(string id)
        {
            return _traits.Find(trait =>trait.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _traits.DeleteOne(trait => trait.Id == id);
        }

        public void Update(string id, Trait trait)
        {
            _traits.ReplaceOne(trait => trait.Id == id, trait);
        }
    }
}

using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class DamageTypeService : IDamageTypeService
    {
        private readonly IMongoCollection<DamageType> _damagetypes;

        public DamageTypeService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _damagetypes = database.GetCollection<DamageType>(settings.DndDamageTypeCollectionName);
        }
        public DamageType Create(DamageType damageType)
        {
            _damagetypes.InsertOne(damageType);
            return damageType;
        }

        public List<DamageType> Get()
        {
            return _damagetypes.Find(damagetype => true).ToList();
        }

        public DamageType Get(string id)
        {
            return _damagetypes.Find(damagetype => damagetype.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _damagetypes.DeleteOne(damagetype => damagetype.Id == id);
        }

        public void Update(string id, DamageType damageType)
        {
            _damagetypes.ReplaceOne(damagetype => damagetype.Id == id, damageType);
        }
    }
}

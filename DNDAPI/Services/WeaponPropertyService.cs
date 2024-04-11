using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class WeaponPropertyService : IWeaponPropertyService
    {
        private readonly IMongoCollection<WeaponProperty> _weaponProperty;
        public WeaponPropertyService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _weaponProperty = database.GetCollection<WeaponProperty>(settings.DndWeaponPropertyCollectionName);
        }
        public WeaponProperty Create(WeaponProperty property)
        {
            _weaponProperty.InsertOne(property);
            return property;
        }
        public List<WeaponProperty> Get()
        {
            return _weaponProperty.Find(property => true).ToList();
        }
        public WeaponProperty Get(string id)
        {
            return _weaponProperty.Find(property => property.Id == id).FirstOrDefault();
        }
        public void Remove(string id)
        {
            _weaponProperty.DeleteOne(property => property.Id == id);
        }
        public void Update(string id, WeaponProperty property)
        {
            _weaponProperty.ReplaceOne(property => property.Id == id, property);
        }

    }
}

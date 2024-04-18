using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IMongoCollection<Equipment> _equipment;

        public EquipmentService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _equipment = database.GetCollection<Equipment>(settings.DndEquipmentCollectionName);
        }
        public Equipment Create(Equipment equipment)
        {
            _equipment.InsertOne(equipment);
            return equipment;
        }

        public List<Equipment> Get()
        {
            return _equipment.Find(equi => true).ToList();
        }

        public Equipment Get(string id)
        {
            return _equipment.Find(equi => equi.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _equipment.DeleteOne(equi => equi.Id == id);
        }

        public void Update(string id, Equipment equipment)
        {
            _equipment.ReplaceOne(equi => equi.Id == id, equipment);
        }
    }
}

using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class EquipmentCategoryService : IEquipmentCategoryService
    {
        private readonly IMongoCollection<EquipmentCategory> _equipmentCategories;

        public EquipmentCategoryService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _equipmentCategories = database.GetCollection<EquipmentCategory>(settings.DndEquipmentCategoriesCollectionName);
        }
        public EquipmentCategory Create(EquipmentCategory equipmentCategory)
        {
            _equipmentCategories.InsertOne(equipmentCategory);
            return equipmentCategory;
        }

        public List<EquipmentCategory> Get()
        {
            return _equipmentCategories.Find(equi => true).ToList();
        }

        public EquipmentCategory Get(string id)
        {
            return _equipmentCategories.Find(equi => equi.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _equipmentCategories.DeleteOne(equi => equi.Id == id);
        }

        public void Update(string id, EquipmentCategory equipmentCategory)
        {
            _equipmentCategories.ReplaceOne(equi => equi.Id == id, equipmentCategory);
        }
    }
}

using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class MagicItemService : IMagicItemService
    {
        private readonly IMongoCollection<MagicItem> _magicItems;

        public MagicItemService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _magicItems = database.GetCollection<MagicItem>(settings.DndMagicItemsName);
        }
        public MagicItem Create(MagicItem item)
        {
            _magicItems.InsertOne(item);
            return item;
        }

        public List<MagicItem> Get()
        {
            return _magicItems.Find(item => true).ToList();
        }

        public MagicItem Get(string id)
        {
            return _magicItems.Find(item => item.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _magicItems.DeleteOne(item => item.Id == id);
        }

        public void Update(string id, MagicItem item)
        {
            _magicItems.ReplaceOne(item => item.Id == id, item);
        }
    }
}

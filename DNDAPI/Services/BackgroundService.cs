using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class BackgroundService : IBackgroundService
    {
        private readonly IMongoCollection<Background> _background;

        public BackgroundService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _background = database.GetCollection<Background>(settings.DndBackgroundCollectionName);
        }
        public Background Create(Background background)
        {
            _background.InsertOne(background);
            return background;
        }

        public List<Background> Get()
        {
            return _background.Find(back => true).ToList();
        }

        public Background Get(string id)
        {
            return _background.Find(back =>  back.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _background.DeleteOne(back => back.Id == id);
        }

        public void Update(string id, Background background)
        {
            _background.ReplaceOne(back => back.Id == id, background);
        }
    }
}

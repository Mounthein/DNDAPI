using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class LevelService: ILevelService
    {
        public readonly IMongoCollection<Level> _level;

        public LevelService(IDndStoreDatabaseSettings setting, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _level = database.GetCollection<Level>(setting.DndLevelCollectioName);
        }
        public Level Create(Level level)
        {
            _level.InsertOne(level);
            return level;
        }

        public List<Level> Get()
        {
            return _level.Find(level => true).ToList();
        }

        public Level Get(string id)
        {
            return _level.Find(level => level.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _level.DeleteOne(level => level.Id == id);
        }

        public void Update(string id, Level level)
        {
            _level.ReplaceOne(level => level.Id == id, level);
        }
    }
}

using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class RaceService : IRaceService
    {
        private readonly IMongoCollection<Race> _race;

        public RaceService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _race = database.GetCollection<Race>(settings.DndRaceCollectionName);
        }

        public Race Create(Race race)
        {
            _race.InsertOne(race);
            return race;
        }

        public List<Race> Get()
        {
            return _race.Find(race => true).ToList();
        }

        public Race Get(string id)
        {
            return _race.Find(race =>  race.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _race.DeleteOne(race => race.Id == id);
        }

        public void Update(string id, Race race)
        {
            _race.ReplaceOne(race => race.Id == id, race);
        }
    }
}

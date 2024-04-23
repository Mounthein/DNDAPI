using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class SubraceService : ISubraceService
    {
        private readonly IMongoCollection<Subrace> _subraceCollection;

        public SubraceService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _subraceCollection = database.GetCollection<Subrace>(settings.DndSubRaceCollectionName);
        }

        public Subrace Create(Subrace subrace)
        {
            _subraceCollection.InsertOne(subrace);
            return subrace;
        }

        public List<Subrace> Get()
        {
            return _subraceCollection.Find(subrace => true).ToList();
        }

        public Subrace Get(string id)
        {
            return _subraceCollection.Find(subrace => subrace.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _subraceCollection.DeleteOne(subrace => subrace.Id == id);
        }

        public void Update(string id, Subrace subrace)
        {
            _subraceCollection.ReplaceOne(subrace => subrace.Id == id, subrace);
        }
    }
}

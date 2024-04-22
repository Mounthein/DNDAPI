using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class SubclassService : ISubclassService
    {
        private readonly IMongoCollection<Subclass> _subclasses;

        public SubclassService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _subclasses = database.GetCollection<Subclass>(settings.DndSubclassesCollectionName);
        }
        public Subclass Create(Subclass subclass)
        {
            _subclasses.InsertOne(subclass);
            return subclass;
        }

        public List<Subclass> Get()
        {
            return _subclasses.Find(subclass => true).ToList();
        }

        public Subclass Get(string id)
        {
            return _subclasses.Find(subclass => subclass.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _subclasses.DeleteOne(subclass => subclass.Id == id);
        }

        public void Update(string id, Subclass subclass)
        {
            _subclasses.ReplaceOne(subclass => subclass.Id == id, subclass);
        }
    }
}

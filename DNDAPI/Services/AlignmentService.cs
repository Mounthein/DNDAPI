using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class AlignmentService : IAlignmentService
    {
        private readonly IMongoCollection<Alignment> _alignment;
        public AlignmentService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _alignment = database.GetCollection<Alignment>(settings.DndAlignmentCollectionName);
        }
        public Alignment Create(Alignment alignment)
        {
            _alignment.InsertOne(alignment);
            return alignment;
        }

        public List<Alignment> Get()
        {
            return _alignment.Find(alignment => true).ToList();
        }

        public Alignment Get(string id)
        {
            return _alignment.Find(alignemt => alignemt.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _alignment.DeleteOne(alignment => alignment.Id == id);
        }

        public void Update(string id, Alignment alignment)
        {
            _alignment.ReplaceOne(align => align.Id == id, alignment);
        }
    }
}

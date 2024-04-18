using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class FeatService : IFeatService
    {
        private readonly IMongoCollection<Feat> _feat;

        public FeatService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _feat = database.GetCollection<Feat>(settings.DndFeatsCollectionName);
        }
        public Feat Create(Feat feat)
        {
            _feat.InsertOne(feat);
            return feat;
        }

        public List<Feat> Get()
        {
            return _feat.Find(feat => true).ToList();
        }

        public Feat Get(string id)
        {
            return _feat.Find(feat => feat.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _feat.DeleteOne(feat => feat.Id == id);
        }

        public void Update(string id, Feat feat)
        {
            _feat.ReplaceOne(feat => feat.Id == id, feat);
        }
    }
}

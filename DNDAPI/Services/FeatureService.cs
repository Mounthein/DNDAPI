using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly IMongoCollection<Feature> _features;

        public FeatureService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _features = database.GetCollection<Feature>(settings.DndFeaturesCollectionName);
        }
        public Feature Create(Feature feature)
        {
            _features.InsertOne(feature);
            return feature;
        }

        public List<Feature> Get()
        {
            return _features.Find(f => true).ToList();
        }

        public Feature Get(string id)
        {
            return _features.Find(f => f.Id == id).FirstOrDefault();
        }
        
        public void Remove(string id)
        {
            _features.DeleteOne(f => f.Id == id);
        }

        public void Update(string id, Feature feature)
        {
            _features.ReplaceOne(f => f.Id == id, feature);
        }
    }
}

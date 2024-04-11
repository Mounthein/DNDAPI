using Amazon.Auth.AccessControlPolicy;
using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class ConditionService : IConditionService
    {
        private readonly IMongoCollection<Conditions> _condition;
        public ConditionService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _condition = database.GetCollection<Conditions>(settings.DndConditionsCollectionName);
        }

        public Conditions Create(Conditions condition)
        {
            _condition.InsertOne(condition);
            return condition;
        }

        public List<Conditions> Get()
        {
            return _condition.Find(con => true).ToList();
        }

        public Conditions Get(string id)
        {
            return _condition.Find(con => con.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _condition.DeleteOne(cond => cond.Id == id);
        }

        public void Update(string id, Conditions condition)
        {
            _condition.ReplaceOne(cond => cond.Id == id, condition);
        }
    }
}

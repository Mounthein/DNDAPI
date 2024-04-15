using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class SkillService : ISkillService
    {
        private readonly IMongoCollection<Skill> _skill;

        public SkillService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _skill = database.GetCollection<Skill>(settings.DndSkillCollectionName);
        }
        public Skill Create(Skill skill)
        {
            _skill.InsertOne(skill);
            return skill;
        }

        public List<Skill> Get()
        {
            return _skill.Find(skill => true).ToList();
        }

        public Skill Get(string skillId)
        {
            return _skill.Find(skill => skill.Id == skillId).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _skill.DeleteOne(skill => skill.Id == id);
        }

        public void Update(string id, Skill skill)
        {
            _skill.ReplaceOne(skill => skill.Id == id, skill);
        }
    }
}

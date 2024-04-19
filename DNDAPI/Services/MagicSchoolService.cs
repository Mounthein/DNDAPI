using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class MagicSchoolService : IMagicSchoolService
    {
        private readonly IMongoCollection<MagicSchool> _magicSchool;

        public MagicSchoolService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _magicSchool = database.GetCollection<MagicSchool>(settings.DndMagicSchoolsCollectionName);
        }
        public MagicSchool Create(MagicSchool magicSchool)
        {
            _magicSchool.InsertOne(magicSchool);
            return magicSchool;
        }

        public List<MagicSchool> Get()
        {
            return _magicSchool.Find(magic => true).ToList();
        }

        public MagicSchool Get(string id)
        {
            return _magicSchool.Find(magic => magic.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _magicSchool.DeleteOne(magic => magic.Id == id);
        }

        public void Update(string id, MagicSchool magicSchool)
        {
            _magicSchool.ReplaceOne(magic => magic.Id == id, magicSchool);
        }
    }
}

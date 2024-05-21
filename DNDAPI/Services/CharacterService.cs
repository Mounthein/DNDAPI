using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly IMongoCollection<Character> _character;

        public CharacterService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _character = database.GetCollection<Character>(settings.DndCharacterCollectionName);
        }
        public Character Create(Character character)
        {
            _character.InsertOne(character);
            return character;
        }

        public List<Character> Get()
        {
            return _character.Find(chara => true).ToList();
        }

        public Character Get(string id)
        {
            return _character.Find(chara => chara.Id == id).FirstOrDefault();
        }

        public List<Character> GetByUserName(string userName)
        {
            return _character.Find(chara => chara.UserName == userName).ToList();
        }

        public void Remove(string id)
        {
            _character.DeleteOne(chara => chara.Id == id);
        }

        public void Update(string id, Character character)
        {
            _character.ReplaceOne(chara => chara.Id == id, character);
        }
    }
}

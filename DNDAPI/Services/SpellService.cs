using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class SpellService : ISpellService
    {
        private readonly IMongoCollection<Spell> _spells;

        public SpellService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _spells = database.GetCollection<Spell>(settings.DndSpellCollectionName);
        }
        public Spell Create(Spell spell)
        {
            _spells.InsertOne(spell);
            return spell;
        }

        public List<Spell> Get()
        {
            return _spells.Find(spell => true).ToList();
        }

        public Spell Get(string id)
        {
            return _spells.Find(spell =>  spell.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _spells.DeleteOne(spell => spell.Id == id);
        }

        public void Update(string id, Spell spell)
        {
            _spells.ReplaceOne(spell => spell.Id == id, spell);
        }
    }
}

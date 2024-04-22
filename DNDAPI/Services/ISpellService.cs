using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ISpellService
    {
        List<Spell> Get();
        Spell Get(string id);
        Spell Create(Spell spell);
        void Update(string id, Spell spell);
        void Remove(string id);
    }
}

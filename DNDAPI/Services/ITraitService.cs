using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ITraitService
    {
        List<Trait> Get();
        Trait Get(string id);
        Trait Create(Trait trait);
        void Update(string id, Trait trait);
        void Remove(string id);
    }
}

using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IFeatService
    {
        List<Feat> Get();
        Feat Get(string id);
        Feat Create(Feat feat);
        void Update(string id, Feat feat);
        void Remove(string id);
    }
}

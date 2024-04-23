using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ISubraceService
    {
        List<Subrace> Get();
        Subrace Get(string id);
        Subrace Create(Subrace subrace);
        void Update(string id,  Subrace subrace);
        void Remove(string id);
    }
}

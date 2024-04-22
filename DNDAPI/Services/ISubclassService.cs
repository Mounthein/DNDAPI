using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ISubclassService
    {
        List<Subclass> Get();
        Subclass Get(string id);
        Subclass Create(Subclass subclass);
        void Update(string id, Subclass subclass);
        void Remove(string id);
    }
}

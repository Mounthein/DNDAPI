using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IAlignmentService
    {
        List<Alignment> Get();
        Alignment Get(string id);
        Alignment Create(Alignment alignment);
        void Update(string id, Alignment alignment);
        void Remove(string id);
    }
}

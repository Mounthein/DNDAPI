using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IClassesService
    {
        List<Classes> Get();
        Classes Get(string id);
        Classes Create(Classes classes);
        void Update(string id, Classes classes);
        void Remove(string id);
    }
}

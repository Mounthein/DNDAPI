using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IBackgroundService
    {
        List<Background> Get();
        Background Get(string id);
        Background Create(Background background);
        void Update(string id, Background background);
        void Remove(string id);
    }
}

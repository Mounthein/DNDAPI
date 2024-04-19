using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ILevelService
    {
        List<Level> Get();
        Level Get(string id);
        Level Create(Level level);
        void Update(string id, Level level);
        void Remove(string id);
    }
}

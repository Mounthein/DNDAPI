using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IRaceService
    {
        List<Race> Get();
        Race Get(string id);
        Race Create(Race race);
        void Update(string id,  Race race);
        void Remove(string id);
    }
}

using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IProficiencyService
    {
        List<Proficiency> Get();
        Proficiency Get(string  id);
        Proficiency Create(Proficiency proficiency);
        void Update(string id, Proficiency proficiency);
        void Remove(string id);
    }
}

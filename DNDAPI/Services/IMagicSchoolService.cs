using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IMagicSchoolService
    {
        List<MagicSchool> Get();
        MagicSchool Get(string id);
        MagicSchool Create(MagicSchool magicSchool);
        void Update(string id, MagicSchool magicSchool);
        void Remove(string id);
    }
}

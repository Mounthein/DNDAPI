using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IDamageTypeService
    {
        List<DamageType> Get();
        DamageType Get(string id);
        DamageType Create(DamageType damageType);
        void Update(string id, DamageType damageType);
        void Remove(string id);
    }
}

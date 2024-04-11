using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IWeaponPropertyService
    {
        List<WeaponProperty> Get();
        WeaponProperty Get(string id);
        WeaponProperty Create(WeaponProperty property);
        void Update(string id, WeaponProperty property);
        void Remove(string id);
    }
}

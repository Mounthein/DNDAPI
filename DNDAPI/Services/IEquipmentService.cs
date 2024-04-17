using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IEquipmentService
    {
        List<Equipment> Get();
        Equipment Get(string id);
        Equipment Create(Equipment equipment);
        void Update(string id, Equipment equipment);
        void Remove(string id);
    }
}

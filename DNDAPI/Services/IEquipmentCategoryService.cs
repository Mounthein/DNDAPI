using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IEquipmentCategoryService
    {
        List<EquipmentCategory> Get();
        EquipmentCategory Get(string id);
        EquipmentCategory Create(EquipmentCategory equipmentCategory);
        void Update(string id, EquipmentCategory equipmentCategory);
        void Remove(string id);
    }
}

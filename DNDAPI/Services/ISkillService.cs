using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ISkillService
    {
        List<Skill> Get();
        Skill Get(string skillId);
        Skill Create(Skill skill);
        void Update(string id, Skill skill);
        void Remove(string id);
    }
}

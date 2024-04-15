using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IAbilityScoreService
    {
        List<AbilityScore> Get();
        AbilityScore Get(string id);
        AbilityScore Create(AbilityScore score);
        void Update(string id, AbilityScore score);
        void Remove(string id);
    }
}

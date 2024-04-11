using Amazon.Auth.AccessControlPolicy;
using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IConditionService
    {
        List<Conditions> Get();
        Conditions Get(string id);
        Conditions Create(Conditions condition);
        void Update(string id, Conditions condition);
        void Remove(Conditions condition);
    }
}

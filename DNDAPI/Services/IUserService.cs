using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IUserService
    {
        User Get(string id);
        User Get(string id, string pass);
        User Create(User user);
        void Update(string id, User user, string check);

        void Remove(string id, string check);
    }
}

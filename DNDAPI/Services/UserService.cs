using Amazon.Auth.AccessControlPolicy;
using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class UserService: IUserService
    {
        private readonly IMongoCollection<User> _users;
        private readonly string _password;

        public UserService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            _password = settings.DndPass;
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>(settings.DndUserCollectionName);
        }

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public User Get(string id, string pass)
        {
            return _users.Find(user => user.UserName == id && user.Password == pass).FirstOrDefault();
        }

        public User Get(string id)
        {
            return _users.Find(user => user.UserName == id).FirstOrDefault();
        }

        public void Remove(string id, string check)
        {
            _users.DeleteOne(user => user.Id == id && check == _password);
        }

        public void Update(string id, User user, string check)
        {
            _users.ReplaceOne(u => u.Id == user.Id && check == _password, user);
        }
    }
}

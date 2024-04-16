using DNDAPI.Models;
using MongoDB.Driver;

namespace DNDAPI.Services
{
    public class ClassesService : IClassesService
    {
        private readonly IMongoCollection<Classes> _classes;

        public ClassesService(IDndStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _classes = database.GetCollection<Classes>(settings.DndClassCollectionName);
        }
        public Classes Create(Classes classes)
        {
            _classes.InsertOne(classes);
            return classes;
        }

        public List<Classes> Get()
        {
            return _classes.Find(clas => true).ToList();
        }

        public Classes Get(string id)
        {
            return _classes.Find(clas =>  clas.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _classes.DeleteOne(clas => clas.Id == id);
        }

        public void Update(string id, Classes classes)
        {
            _classes.ReplaceOne(clas => clas.Id == id, classes);
        }
    }
}

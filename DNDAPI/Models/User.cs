using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("username")]
        public string UserName { get; set; } = String.Empty;

        [BsonElement("password")]
        public string Password { get; set; } = String.Empty;
    }
}

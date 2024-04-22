using DNDAPI.Models.Commons;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models
{
    public class Proficiency
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("index")]
        public string Index { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;

        [BsonElement("classes")]
        public From[]? Classes { get; set; }

        [BsonElement("races")]
        public From[]? Races { get; set; }

        [BsonElement("reference")]
        public From? Reference { get; set; }
    }
}

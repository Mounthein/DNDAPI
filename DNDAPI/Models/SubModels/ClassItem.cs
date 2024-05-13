using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ClassItem
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("level")]
        public int? Level { get; set; }

        [BsonElement("subclass")]
        public string? Subclass { get; set; }
    }
}

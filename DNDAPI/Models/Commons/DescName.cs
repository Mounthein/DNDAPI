using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class DescName
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; } = string.Empty;
    }
}

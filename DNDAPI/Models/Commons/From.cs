using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class From
    {
        [BsonElement("index")]
        public string Index { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;
    }
}

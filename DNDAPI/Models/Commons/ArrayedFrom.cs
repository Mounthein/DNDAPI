using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class ArrayedFrom
    {
        [BsonElement("index")]
        public string[]? Index { get; set; }

        [BsonElement("name")]
        public string[]? Name { get; set; }
    }
}

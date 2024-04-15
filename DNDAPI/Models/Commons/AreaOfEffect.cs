using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class AreaOfEffect
    {
        [BsonElement("size")]
        public int? Size { get; set; }

        [BsonElement("type")]
        public string Type { get; set; } = String.Empty;
    }
}

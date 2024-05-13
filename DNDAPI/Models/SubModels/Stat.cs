using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class Stat
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("value")]
        public int? Value { get; set; }
    }
}

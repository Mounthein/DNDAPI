using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class RaceCharacter
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("speed")]
        public string? Speed { get; set; } = string.Empty;

        [BsonElement("size")]
        public string? Size { get; set; } = string.Empty;

        [BsonElement("subrace")]
        public string? Subrace { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class SpellCharacter
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; } = string.Empty;

        [BsonElement("school")]
        public string? School { get; set; } = string.Empty;

        [BsonElement("level")]
        public int? level { get; set; }

        [BsonElement("casting_time")]
        public string? CastingTime { get; set; } = string.Empty;

        [BsonElement("duration")]
        public string? Duration { get; set; } = string.Empty;
    }
}

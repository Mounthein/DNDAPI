using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ArmorClassCharacter
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("type")]
        public string? Type { get; set; } = string.Empty;

        [BsonElement("value")]
        public int? Value { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class AlignmentCharacter
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("abbreviation")]
        public string? Abbreviation { get; set; } = string.Empty;

    }
}

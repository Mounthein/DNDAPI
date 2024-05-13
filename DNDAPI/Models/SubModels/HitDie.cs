using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class HitDie
    {
        [BsonElement("type")]
        public string? Type { get; set; } = string.Empty;

        [BsonElement("quantity")]
        public string? Quantity { get; set; } = string.Empty;

    }
}

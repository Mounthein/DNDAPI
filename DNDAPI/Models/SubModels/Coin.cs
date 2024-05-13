using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class Coin
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("quantity")]
        public int? Quantity { get; set; }
    }
}

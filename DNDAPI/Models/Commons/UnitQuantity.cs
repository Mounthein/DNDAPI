using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class UnitQuantity
    {
        [BsonElement("quantity")]
        public int? Quantity { get; set; }

        [BsonElement("unit")]
        public string String { get; set; } = String.Empty;
    }
}

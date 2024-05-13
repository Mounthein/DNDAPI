using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class EquipmentCharacter
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("equipment_category")]
        public string? EquipmentCategory { get; set; } = string.Empty;

        [BsonElement("quantity")]
        public int? quantity { get; set; }

    }
}

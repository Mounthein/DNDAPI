using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class StartingEquipmentClasses
    {
        [BsonElement("equipment")]
        public From? Equipment { get; set; }

        [BsonElement("quantity")]
        public int? quantity { get; set;}
    }
}

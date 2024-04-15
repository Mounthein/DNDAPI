using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class FromBackground
    {
        [BsonElement("equipment_category")]
        public From? EquipmentCategory { get; set; }
    }
}

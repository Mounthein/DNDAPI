using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class TwoHandedDamageEquipment
    {
        [BsonElement("damage_dice")]
        public string DamageDice { get; set; } = String.Empty;

        [BsonElement("damage_type")]
        public From? DamageType { get; set; }
    }
}

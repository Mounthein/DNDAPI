using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DamageSpell
    {
        [BsonElement("damage_at_character_level")]
        public DamageCharacterLevelSpell? DamageAtCharacterLevel { get; set; }

        [BsonElement("damage_at_slot_level")]
        public DamageSlotLevelSpell? DamageSlotLevel { get; set; }

        [BsonElement("damage_type")]
        public From? DamageType { get; set; }
    }
}

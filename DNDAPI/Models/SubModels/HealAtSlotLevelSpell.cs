using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class HealAtSlotLevelSpell
    {
        [BsonElement("heal_at_slot_level1")]
        public string HealAtSlotLevel1 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level2")]
        public string HealAtSlotLevel2 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level3")]
        public string HealAtSlotLevel3 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level4")]
        public string HealAtSlotLevel4 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level5")]
        public string HealAtSlotLevel5 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level6")]
        public string HealAtSlotLevel6 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level7")]
        public string HealAtSlotLevel7 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level8")]
        public string HealAtSlotLevel8 { get; set; } = String.Empty;

        [BsonElement("heal_at_slot_level9")]
        public string HealAtSlotLevel9 { get; set; } = String.Empty;
    }
}

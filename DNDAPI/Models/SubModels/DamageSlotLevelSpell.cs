using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DamageSlotLevelSpell
    {
        [BsonElement("dmSlLvl1")]
        public string DmSlLvl1 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl2")]
        public string DmSlLvl2 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl3")]
        public string DmSlLvl3 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl4")]
        public string DmSlLvl4 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl5")]
        public string DmSlLvl5 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl6")]
        public string DmSlLvl6 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl7")]
        public string DmSlLvl7 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl8")]
        public string DmSlLvl8 { get; set; } = String.Empty;

        [BsonElement("dmSlLvl9")]
        public string DmSlLvl9 { get; set; } = String.Empty;
    }
}

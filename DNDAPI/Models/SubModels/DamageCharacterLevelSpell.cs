using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DamageCharacterLevelSpell
    {
        [BsonElement("dmChLvl1")]
        public string DmChLcl1 { get; set; } = String.Empty;

        [BsonElement("dmChLvl5")]
        public string DmChLcl5 { get; set; } = String.Empty;

        [BsonElement("dmChLvl11")]
        public string DmChLcl11 { get; set; } = String.Empty;

        [BsonElement("dmChLvl17")]
        public string DmChLcl17 { get; set; } = String.Empty;
    }
}

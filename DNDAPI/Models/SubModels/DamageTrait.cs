using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DamageTrait
    {
        [BsonElement("damage_at_character_level")]
        public DamageCharacterLevelTrait? DamageCharacterLevel { get; set; }

        [BsonElement("damage_type")]
        public From? DamageType { get; set; }
    }
}

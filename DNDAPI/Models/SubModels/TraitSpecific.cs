using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class TraitSpecific
    {
        [BsonElement("breath_weapon")]
        public BreathWeaponTrait? BreathWeapon { get; set; }

        [BsonElement("damage_type")]
        public From? DamageType { get; set; }

        [BsonElement("spell_options")]
        public ExpertiseOptionFeature? SpellOptions { get; set; }

        [BsonElement("subtrait_options")]
        public ExpertiseOptionFeature? SubtraitOptions { get; set; }
    }
}

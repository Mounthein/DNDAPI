using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class SpellAbility
    {
        [BsonElement("spellcasting_ability")]
        public string? SpellCastingAbility { get; set; }

        [BsonElement("spell_save_dc")]
        public int? SpellSaveDC { get; set; }

        [BsonElement("spell_attack_bonus")]
        public int? SpellAttackBonus { get; set; }

    }
}

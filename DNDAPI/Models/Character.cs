using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using DNDAPI.Models.SubModels;
using DNDAPI.Models.Commons;

namespace DNDAPI.Models
{
    public class Character
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("userName")]
        public string? UserName { get; set; } = string.Empty;

        [BsonElement("level")]
        public int? Level { get; set; }

        [BsonElement("inspiration")]
        public bool Inspiration { get; set; }

        [BsonElement("background")]
        public string? Background { get; set; } = string.Empty;

        [BsonElement("race")]
        public RaceCharacter? Race { get; set; }

        [BsonElement("alignment")]
        public AlignmentCharacter? Alignment { get; set; }

        [BsonElement("hit_points")]
        public HitPointsCharacter? HitPoints { get; set; }

        [BsonElement("hit_die")]
        public HitDie[]? HitDie { get; set; }

        [BsonElement("death_saves")]
        public DeathSaves? DeathSaves { get; set; }

        [BsonElement("temporary_hit_points")]
        public int? TemporaryHitPoints { get; set; }

        [BsonElement("exhaustion")]
        public int? Exhaustion { get; set; }

        [BsonElement("armor_class")]
        public ArmorClassCharacter? ArmorClass { get; set; }

        [BsonElement("classes")]
        public ClassItem[]? Classes { get; set; }

        [BsonElement("experience_points")]
        public int? ExperiencePoints { get; set; }

        [BsonElement("stats")]
        public Stat[]? Stats { get; set; }

        [BsonElement("skill_proficiencies")]
        public SkillProficiency[]? SkillProficiencies { get; set; }

        [BsonElement("languages")]
        public TypeName[]? Languages { get; set; }

        [BsonElement("other_proficiencies")]
        public TypeName[]? OtherProficiencies { get; set; }

        [BsonElement("equipment")]
        public EquipmentCharacter[]? Equipment { get; set; }

        [BsonElement("coin_pouch")]
        public Coin[]? CoinPouch { get; set; }

        [BsonElement("features")]
        public DescName[]? Features { get; set; }

        [BsonElement("traits")]
        public DescName[]? Traits { get; set; }

        [BsonElement("spell_abilities")]
        public SpellAbility[]? SpellAbilities { get; set; }

        [BsonElement("prepared_spells")]
        public SpellCharacter[]? PreparedSpells { get; set; }

        [BsonElement("known_spells")]
        public SpellCharacter[]? KnownSpells { get; set; }

        [BsonElement("passive_wisdom")]
        public int? PassiveWisdom { get; set; }

        [BsonElement("initiative")]
        public int? Initiative { get; set; }

        [BsonElement("speed")]
        public int? Speed { get; set; }

        [BsonElement("proficiency_bonus")]
        public int? ProficiencyBonus { get; set; }

        [BsonElement("saving_throws")]
        public string[]? SavingThrows { get; set; }

        [BsonElement("personality_traits")]
        public string? PersonalityTraits { get; set; } = string.Empty;

        [BsonElement("ideals")]
        public string? Ideals { get; set; } = string.Empty;

        [BsonElement("bonds")]
        public string? Bonds { get; set; } = string.Empty;

        [BsonElement("flaws")]
        public string? Flaws { get; set; } = string.Empty;

        [BsonElement("character_appearance")]
        public string? CharacterAppearance { get; set; } = string.Empty;

        [BsonElement("character_backstory")]
        public string? CharacterBackstory { get; set; } = string.Empty;

        [BsonElement("allies_organizations")]
        public string? AlliesOrganizations { get; set; } = string.Empty;

        [BsonElement("symbol")]
        public string? Symbol { get; set; } = string.Empty;
    }
}

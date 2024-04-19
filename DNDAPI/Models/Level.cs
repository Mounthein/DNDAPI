using DNDAPI.Models.Commons;
using DNDAPI.Models.SubModels;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models
{
    public class Level
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("ability_score_bonuses")]
        public int? AbilityScoreBonuses { get; set; }

        [BsonElement("classLevels")]
        public From? ClassLevels { get; set; }

        [BsonElement("class_specific")]
        public ClassSpecificLevel? ClassSpecific { get; set; }

        [BsonElement("features")]
        public From[]? Features { get; set; }

        [BsonElement("index")]
        public string Index { get; set; } = String.Empty;
        
        [BsonElement("level")]
        public int? LevelN { get; set; }

        [BsonElement("prof_bonus")]
        public int? ProficiencyBonus { get; set; }

        [BsonElement("spellcasting")]
        public SpellcastingLevel? Spellcasting { get; set;}

        [BsonElement("subclass")]
        public From? Subcalss { get; set; }

        [BsonElement("subclass_specific")]
        public SubclassSpecificLevel[]? Subcategories { get; set; }
    }
}

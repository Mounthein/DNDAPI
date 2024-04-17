using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class SpellcastingClass
    {
        [BsonElement("info")]
        public InfoClasses[]? Info { get; set; }

        [BsonElement("level")]
        public int? Level { get; set; }

        [BsonElement("spellcasting_ability")]
        public From? SpellcastingAbility { get; set; }
    }
}

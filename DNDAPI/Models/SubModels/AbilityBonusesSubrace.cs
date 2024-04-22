using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class AbilityBonusesSubrace
    {
        [BsonElement("ability_score")]
        public From? AbilityScore { get; set; }

        [BsonElement("bonus")]
        public int? Bonus { get; set; }
    }
}

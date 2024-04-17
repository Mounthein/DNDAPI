using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class Prerequisites
    {
        [BsonElement("ability_score")]
        public From? AbilityScore { get; set; }

        [BsonElement("minimum_score")]
        public int? MinimumScore { get; set; }
    }
}
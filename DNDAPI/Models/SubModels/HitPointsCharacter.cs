using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class HitPointsCharacter
    {
        [BsonElement("maximum")]
        public int? Maximum { get; set; }

        [BsonElement("current")]
        public int? Current { get; set; }

        [BsonElement("temporary")]
        public int? Temporary { get; set; }
    }
}

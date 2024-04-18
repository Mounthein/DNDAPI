using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ExpertiseOptionFeature
    {
        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("from")]
        public ExpertiseOptionFromFeature[]? From { get; set; }
    }
}

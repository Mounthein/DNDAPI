using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class FeatureSpecific
    {
        [BsonElement("expertise_option")]
        public ExpertiseOptionFeature? ExpertiseOption { get; set; }

        [BsonElement("invocations")]
        public InvocationFeature? Invocations { get; set; }

        [BsonElement("subfeature_options")]
        public SubFeatureOptions? SubfeatureOptions { get; set; }
    }
}

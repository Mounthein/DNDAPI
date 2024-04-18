using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class InvocationFeature
    {
        [BsonElement("name")]
        public string[]? Name { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class AlignmentsBackground
    {
        [BsonElement("index")]
        public string[]? Index { get; set; }

        [BsonElement("name")]
        public string[]? Name { get; set; }
    }
}

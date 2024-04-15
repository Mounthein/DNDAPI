using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class IdealBackground
    {
        [BsonElement("alignments")]
        public From[]? Alignments { get; set; }

        [BsonElement("desc")]
        public string Description { get; set; } = String.Empty;
    }
}

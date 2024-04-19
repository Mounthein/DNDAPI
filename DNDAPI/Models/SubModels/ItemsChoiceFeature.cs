using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ItemsChoiceFeature
    {
        [BsonElement("choose")]
        public int[]? Choose { get; set; }

        [BsonElement("from")]
        public ArrayedFrom[]? Item { get; set; }
    }
}

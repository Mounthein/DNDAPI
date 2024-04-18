using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ItemsFeature
    {
        [BsonElement("choice")]
        public ItemsChoiceFeature Choice { get; set; }

        [BsonElement("item")]
        public From? Item { get; set; }
    }
}

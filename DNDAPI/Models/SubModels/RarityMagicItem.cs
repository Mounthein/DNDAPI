using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class RarityMagicItem
    {
        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;
    }
}

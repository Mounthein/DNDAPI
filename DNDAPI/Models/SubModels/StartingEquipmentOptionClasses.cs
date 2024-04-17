using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class StartingEquipmentOptionClasses
    {
        [BsonElement("desc")]
        public string Description { get; set; } = String.Empty;

        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("from")]
        public List<OptionItemClasses[]>? From { get; set; }
    }
}

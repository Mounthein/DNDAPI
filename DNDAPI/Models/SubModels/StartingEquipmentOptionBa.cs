using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class StartingEquipmentOptionBa
    {
        [BsonElement("choose")]
        public int? Choose { get; set;}

        [BsonElement("from")]
        public FromBackground? From { get; set;}

        [BsonElement("type")]
        public string Type { get; set; } = String.Empty;
    }
}

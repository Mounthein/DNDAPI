using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ProficiencyChoiceClasses
    {
        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("desc")]
        public string Description { get; set; }

        [BsonElement("from")]
        public From[]? From { get; set; }
    }
}

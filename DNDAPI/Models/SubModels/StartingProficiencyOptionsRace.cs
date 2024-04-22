using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class StartingProficiencyOptionsRace
    {
        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("desc")]
        public string Description { get; set; } = String.Empty;

        [BsonElement("from")]
        public From[]? From { get; set; }
    }
}

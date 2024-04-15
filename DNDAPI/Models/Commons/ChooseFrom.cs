using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class ChooseFrom
    {
        [BsonElement("choose")]
        public int? Choose {  get; set; }

        [BsonElement("from")]
        public string[]? From { get; set; }
    }
}

using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Controllers
{
    [BsonNoId]
    public class LanguageOptionsCommon
    {
        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("from")]
        public From[]? From { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DeathSaves
    {
        [BsonElement("succes")]
        public int? Success { get; set; }

        [BsonElement("failures")]
        public int? Failures { get; set; }

    }
}

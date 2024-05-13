using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class SkillProficiency
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("bonus")]
        public double? bonus { get; set; }
    }
}

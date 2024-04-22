using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class OptionRace
    {
        [BsonElement("options")]
        public OptionsRace? Options { get; set; }
    }
}

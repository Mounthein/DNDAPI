using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;
namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class MultiClassing
    {
        [BsonElement("prerequisites")]
        public Prerequisites[]? Prerequisites { get; set; }

        [BsonElement("proficiencies")]
        public From[]? Proficiencies { get; set; }
    }
}

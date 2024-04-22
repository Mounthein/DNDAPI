using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DCSpell
    {
        [BsonElement("dc_success")]
        public string dc_success { get; set; } = String.Empty;

        [BsonElement("dc_type")]
        public From? dc_type { get; set;}

        [BsonElement("desc")]
        public string dc_desc { get; set;} = String.Empty;
    }
}

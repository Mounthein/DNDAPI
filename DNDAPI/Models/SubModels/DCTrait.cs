using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class DCTrait
    {
        [BsonElement("success_type")]
        public string SuccessType { get; set; } = String.Empty;

        [BsonElement("dc_type")]
        public From? DcType { get; set; }
    }
}

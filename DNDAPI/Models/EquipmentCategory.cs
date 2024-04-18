﻿using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models
{
    public class EquipmentCategory
    {
        [BsonId]
        [BsonElement("_id")]
        public string Id { get; set; } = String.Empty;

        [BsonElement("equipment")]
        public From[]? Equipment { get; set; }

        [BsonElement("index")]
        public string Index { get; set; } = String.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;
    }
}

﻿using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class IdealsBackground
    {
        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("from")]
        public IdealBackground[]? From { get; set; }

        [BsonElement("type")]
        public string Type { get; set; } = String.Empty;
    }
}

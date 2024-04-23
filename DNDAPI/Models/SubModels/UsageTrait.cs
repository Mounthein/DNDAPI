﻿using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class UsageTrait
    {
        [BsonElement("times")]
        public int? Times { get; set; }

        [BsonElement("type")]
        public string Type { get; set; } = String.Empty;
    }
}

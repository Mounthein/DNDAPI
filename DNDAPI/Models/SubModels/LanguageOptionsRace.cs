﻿using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class LanguageOptionsRace
    {
        [BsonElement("choose")]
        public int? Choose { get; set; }

        [BsonElement("from")]
        public From[]? From { get; set; }

        [BsonElement("type")]
        public string Type { get; set; } = String.Empty;
    }
}

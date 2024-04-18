﻿using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.Commons
{
    [BsonNoId]
    public class Prerequisites
    {
        [BsonElement("ability_score")]
        public From? AbilityScore { get; set; }

        [BsonElement("minimum_score")]
        public int? MinimumScore { get; set; }
    }
}
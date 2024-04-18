﻿using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class ContentsEquipment
    {
        [BsonElement("item")]
        public From[]? Item { get; set; }

        [BsonElement("quantity")]
        public int? Quantity { get; set; }
    }
}

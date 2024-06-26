﻿using DNDAPI.Models.Commons;
using MongoDB.Bson.Serialization.Attributes;

namespace DNDAPI.Models.SubModels
{
    [BsonNoId]
    public class StartingEquipmentBa
    {
        [BsonElement("equipment")]
        public From? Equipment { get; set; }

        [BsonElement("quantity")]
        public int? Quantity { get; set; }
    }
}

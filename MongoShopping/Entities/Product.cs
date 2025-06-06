﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoShopping.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
    }
}

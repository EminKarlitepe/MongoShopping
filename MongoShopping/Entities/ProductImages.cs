using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoShopping.Entities
{
    public class ProductImages
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ProductId { get; set; }
    }
}

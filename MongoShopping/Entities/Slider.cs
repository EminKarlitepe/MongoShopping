using MongoDB.Bson.Serialization.Attributes;

namespace MongoShopping.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string SectionId { get; set; }
        public string SectionName { get; set; }
        public string AnchorId { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}

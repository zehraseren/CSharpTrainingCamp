using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CSTC601.MongoDb.Entities
{
    public class Customer
    {
        /* 
         * MongoDb'de ID'ler string olarak tutulur
         * Bson = Binary Json | Json benzeri dokümandır
        */

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public decimal CustomerBalance { get; set; }
        public int CustomerShoppingCount { get; set; }
    }
}

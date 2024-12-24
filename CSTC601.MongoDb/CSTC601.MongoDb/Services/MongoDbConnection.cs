using MongoDB.Bson;
using MongoDB.Driver;

namespace CSTC601.MongoDb.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _database;

        public MongoDbConnection()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("Db601Customer");
        }

        public IMongoCollection<BsonDocument> GetCustomerCollection()
        {
            return _database.GetCollection<BsonDocument>("Customers");
        }
    }
}

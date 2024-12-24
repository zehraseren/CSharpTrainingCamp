using CSTC601.MongoDb.Entities;
using MongoDB.Bson;

namespace CSTC601.MongoDb.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();

            var document = new BsonDocument
            {
                {"CustomerName", customer.CustomerName},
                {"CustomerSurname", customer.CustomerSurname },
                {"CustomerCity", customer.CustomerCity },
                {"CustomerBalance", customer.CustomerBalance },
                {"CustomerShoppingCount", customer.CustomerShoppingCount}
            };

            customerCollection.InsertOne(document);
        }
    }
}

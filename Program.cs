using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectMongoDB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Replace the connection string with your MongoDB Atlas URI.
            var connectionString = "mongodb+srv://<YourUserName>:<YourPAssword>@testdatabase.ywvasfj.mongodb.net/?retryWrites=true&w=majority&appName=TestDatabase";

            // Create a MongoClient object.
            var client = new MongoClient(connectionString);

            // Get the database and collection.
            var database = client.GetDatabase("testdatabase");
            var collection = database.GetCollection<BsonDocument>("your_collection_name");

            // Now you can perform operations on the collection.
        }
    }
}

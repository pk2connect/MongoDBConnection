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
            var connectionString = "mongodb+srv://<YourUserName>:<YourPAssword>@Your_DataBase_Name.ywvasfj.mongodb.net/?retryWrites=true&w=majority&appName=Your_DataBase_Name";

            // Create a MongoClient object.
            var client = new MongoClient(connectionString);

            // Get the database and collection.
            var database = client.GetDatabase("Your_Dataaase_Name");
            var collection = database.GetCollection<BsonDocument>("your_collection_name");

            // Now you can perform operations on the collection.
        }
    }
}

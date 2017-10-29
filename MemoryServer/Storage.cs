using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryServer {
	class Storage {
		public Storage() {
			MongoClient client = new MongoClient("mongodb://localhost:27017");
			IMongoDatabase database = client.GetDatabase("memory");
			var accounts = database.GetCollection<BsonDocument>("accounts");
			var docs = accounts.Find(new BsonDocument()).FirstOrDefault();
			Console.WriteLine(docs.ToString());

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GardenGroupDAO
{
    public class MongoDB
    {
        private static MongoDB uniqueInstance;
        private readonly IMongoDatabase db;

        public static MongoDB GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new MongoDB();
            return uniqueInstance;
        }

        private MongoDB()
        {
            var client = new MongoClient("mongodb+srv://test_admin1:Test123@it2agroup4.xilpy.mongodb.net/IT2AGROUP4?retryWrites=true&w=majority");
            db = client.GetDatabase("GardenGroup");
        }

        public bool GetUsersCollection(string LastName)
        {
            IMongoCollection<User> userCollection = db.GetCollection<User>("Users");
            List<User> users = userCollection.AsQueryable().ToList<User>();
            bool condition = false;
            int count = 0;
            foreach (User user in users)
            {
                if (user.LastName == LastName)
                {
                    count++;
                }
                
            }
            return count >= 1;
        }
    }
}

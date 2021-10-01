using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAO
{
    public class MongoDB
    {
        private readonly IMongoDatabase db;
        private static MongoDB uniqueInstance;

        public static MongoDB GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new MongoDB();

            return uniqueInstance;
        }

        private MongoDB()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://test_admin1:Test123@it2agroup4.xilpy.mongodb.net/IT2AGROUP4?retryWrites=true&w=majority");
            db = dbClient.GetDatabase("GardenGroup");
        }
    }
}

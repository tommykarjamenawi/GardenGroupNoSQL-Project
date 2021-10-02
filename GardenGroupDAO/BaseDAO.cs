using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using System.Windows;

namespace GardenGroupDAO
{
    public abstract class BaseDAO
    {
        private static MongoClient uniqueInstance = null;

        private BaseDAO() 
        {
            
        }
        public static MongoClient GetInstance()
        {
            if (uniqueInstance == null)
            {
                try
                {
                    uniqueInstance = new MongoClient("mongodb+srv://test_admin1:Test123@it2agroup4.xilpy.mongodb.net/IT2AGROUP4?retryWrites=true&w=majority");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to connect to datebase" + e.Message);
                }
            }
            return uniqueInstance;
        }
    }
}

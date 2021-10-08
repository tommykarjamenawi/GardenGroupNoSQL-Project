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
        protected static IMongoDatabase db;
        public MongoDB()
        {
            if(db==null)
            {
                var client = new MongoClient("mongodb+srv://test_admin1:Test123@it2agroup4.xilpy.mongodb.net/IT2AGROUP4?retryWrites=true&w=majority");
                db = client.GetDatabase("GardenGroup");
            }
        }

        // inserting a document
        public void InsertDocument<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        } 

        // getting a document
        public List<T> GetDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find<T>(new BsonDocument()).ToList();
        }

        // updating document
        public void UpdateDocument<T>(ObjectId id, string table, T updatedRecord)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.ReplaceOne(filter, updatedRecord, new ReplaceOptions() { IsUpsert = true });
        }

        // deleting document
        public void DeleteDocument<T>(ObjectId id, string table)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }

        public List<T> GetSortedIDDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var sort = Builders<T>.Sort.Descending("Id");

            return collection.Find<T>(new BsonDocument()).Sort(sort).ToList();
        }

        public List<T> GetSortedPriorityDocuments<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            var prioritySort = Builders<T>.Sort.Descending("Priority");
            var reportedDateSort = Builders<T>.Sort.Descending("ReportedDate");

            return collection.Find<T>(new BsonDocument()).Sort(reportedDateSort).Sort(prioritySort).ToList();
        }


        public bool GetUsersCollection(string email, string password)
        {
            IMongoCollection<User> userCollection = db.GetCollection<User>("Users");
            List<User> users = userCollection.AsQueryable().ToList<User>();
            int count = 0;
            foreach (User user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    count++;
                }            
            }
            return count >= 1;
        }
        public List<T> FindByQuery<T>(string table, FilterDefinition<T> filter)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find<T>(filter).ToList();
        }



        public User FindOneByEmail(string email)
        {
            var filter = Builders<User>.Filter.Eq("Email", email);
            List<User> users = FindByQuery<User>("Users", filter);

            return users.Count > 0 ? users[0] : null;
        }
    }
}

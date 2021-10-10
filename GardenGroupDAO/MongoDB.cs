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

        public List<T> GetUsersTicketsSortedByIDDocuments<T>(string table, User user)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("ReportedBy", user.Id);
            var sort = Builders<T>.Sort.Descending("Id");

            return collection.Find<T>(filter).Sort(sort).ToList();
        }

        public List<T> GetUsersTicketsSortedByPriorityDocuments<T>(string table, User user)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("ReportedBy", user.Id);
            var prioritySort = Builders<T>.Sort.Descending("Priority");
            var reportSort = Builders<T>.Sort.Descending("ReportedDate");

            return collection.Find<T>(filter).Sort(reportSort).Sort(prioritySort).ToList();
        }

        public List<T> FindByQuery<T>(string table, FilterDefinition<T> filter)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find<T>(filter).ToList();
        }
    }
}

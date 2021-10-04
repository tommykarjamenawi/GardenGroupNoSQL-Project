﻿using System;
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
        public void UpdateDocument<T>(string id, string table, T updatedRecord)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.ReplaceOne(filter, updatedRecord, new ReplaceOptions() { IsUpsert = true });
        }

        // deleting document
        public void DeleteDocument<T>(string table, string id)
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


        public bool GetUsersCollection(string LastName)
        {
            IMongoCollection<User> userCollection = db.GetCollection<User>("Users");
            List<User> users = userCollection.AsQueryable().ToList<User>();
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

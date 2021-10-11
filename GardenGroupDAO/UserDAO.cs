using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAO
{
   public class UserDAO : MongoDB
    {
        string COLLECTION_NAME = "Users";

        public void AddUser(User user)
        {
            InsertDocument<User>(COLLECTION_NAME, user);
        }

        public List<User> GetAllUsers()
        {
            IMongoCollection<User> userCollection = db.GetCollection<User>("Users");
            return userCollection.AsQueryable().ToList<User>();
        }

        public User SearchUsers(string email)
        {
           return FindOneByEmail(email);
        }

        public User GetUserByEmail(string email)
        {
            return FindOneByEmail(email);
        }

        public User FindOneByEmail(string email)
        {
            var filter = Builders<User>.Filter.Eq("Email", email);
            List<User> users = FindByQuery<User>("Users", filter);

            return users.Count > 0 ? users[0] : null;
        }

        public User GetUserByEmailTest(string email)
        {
            IMongoCollection<User> collection = db.GetCollection<User>(COLLECTION_NAME);
            return (User)collection.Find<User>(User => User.Email == email).FirstOrDefault();
        }

        //public bool GetUsersCollection(string email, string password)
        //{
        //    IMongoCollection<User> userCollection = db.GetCollection<User>("Users");
        //    List<User> users = userCollection.AsQueryable().ToList<User>();
        //    int count = 0;
        //    foreach (User user in users)
        //    {
        //        if (user.Email == email && user.Password == password)
        //        {
        //            count++;
        //        }            
        //    }
        //    return count >= 1;
        //}
    }
}

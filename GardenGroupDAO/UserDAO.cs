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
        readonly string COLLECTION_NAME = "Users";

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

      
        public void UpdateUser(User user)
        {
            UpdateDocument<User>(user.Id, COLLECTION_NAME, user);
        }

        public void RemoveUser(User user)
        {
            DeleteDocument<User>(user.Id, COLLECTION_NAME);
        }
    }
}

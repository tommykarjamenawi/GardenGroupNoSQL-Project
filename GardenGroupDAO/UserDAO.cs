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
        string TABLE_NAME = "Users";

        public void AddUser(User user)
        {
            InsertDocument<User>(TABLE_NAME, user);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = GetDocuments<User>(TABLE_NAME);

            return users;
        }

        public User SearchUsers(string email)
        {
           return FindOneByEmail(email);
        }

        // test query
        public User GetUser(string email, string password)
        {
            IMongoCollection<User> collection = db.GetCollection<User>("Users");
            return (User)collection.Find<User>(User => User.Email == email && User.Password == password).FirstOrDefault();
        }
    }
}

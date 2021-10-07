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
            User checkuser = FindOneByEmail(user.Email);

            if (checkuser != null)
            {
                throw new Exception("Email already  registerd to other User!");
            }
            else
            {
                InsertDocument<User>(TABLE_NAME, user);
            }
        }

        private User FindOneByEmail(string email)
        {

            // need to ADD a working querie
            return null;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = GetDocuments<User>(TABLE_NAME);

            return users;
        }

        public List<User> SearchUsers(String searchBox)
        {

            // need to ADD a working querie
            List<User> user = GetDocuments<User>(TABLE_NAME);
            return user;
        }
    }
}

using GardenGroupDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using MongoDB.Bson;

namespace GardenGroupLogic
{
    
    public class UserService 
    {
        UserDAO userdao = new UserDAO();

        public void AddUser(User user)
        {
            userdao.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return userdao.GetAllUsers();
        }

        public User SearchUsers(String searchBox)
        {
            return userdao.SearchUsers(searchBox);
        }

        public User GetUserByEmail(string email, string password)
        {
            User user = userdao.GetUserByEmail(email);
            if (user == null) { return null;}
            else if (user.Password == password) { return user; }
            return null;  
        }
        public User GetUserByEmailHashed(string email)
        {
            User user = userdao.GetUserByEmail(email);
            if (user == null) { return null; } else { return user; }
        }

        public User GetUserObjectById(ObjectId id)
        {
            return userdao.GetUserObjectById(id);
        }

       public void UpdateUser(User user)
        {
            userdao.UpdateUser(user);
        }
        public void RemoveUser(User user)
        {
            userdao.RemoveUser(user);
        }
    }
}

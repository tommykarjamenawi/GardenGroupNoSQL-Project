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
        private UserDAO userdao;
        public UserService()
        {
            userdao = new UserDAO();
        }

        public void AddUser(User user)
        {
            userdao.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return userdao.GetAllUsers();
        }

        public User SearchUsers(String email)
        {
            return userdao.GetUserByEmail(email);
        }

        public User GetUserByEmail(string email, string password)
        {
            VerifyHashedPassword verifyHashedPassword = new VerifyHashedPassword(); // will verify plain password with the hashed password in the database
            User user = userdao.GetUserByEmail(email);
            if (user == null) { return null;}
            else if (verifyHashedPassword.VerifyPassword(password, email)) { return user; }
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

using GardenGroupDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;

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
            return user.Password == password ? user : null; // check if password matches the email
        }

        public User GetUserByEmailTest(string email)
        {
            return userdao.GetUserByEmailTest(email);
        }
    }
}

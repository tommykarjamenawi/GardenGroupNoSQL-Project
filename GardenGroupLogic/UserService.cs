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
       

        public bool CheckUser(string email, string password)
        {
            return userdao.GetUsersCollection(email, password);
        }

        public void AddUser(User user)
        {
            userdao.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return userdao.GetAllUsers();
        }

        //public List<User> GetUsers()
        //{
       //     return userdao.GetUsers();
       // }

        public User SearchUsers(String searchBox)
        {
            return userdao.SearchUsers(searchBox);
        }

        public User GetUser(string email, string password)
        {
            return userdao.GetUser(email, password);
        }
    }
}

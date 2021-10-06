﻿using GardenGroupDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;

namespace GardenGroupLogic
{
    
    public class UserService : BaseDAO
    {
        UserDAO userdao = new UserDAO();
        public UserService()
        {

        }

        public bool CheckUser(string email, string password)
        {
            return db.GetUsersCollection(email, password);
        }

        public void AddUser(User user)
        {
            userdao.AddUser(user);
        }

        public List<User> GetAllUsers()
        {
            return userdao.GetAllUsers();
        }

        public List<User> SearchUsers(String searchBox)
        {
            return userdao.SearchUsers(searchBox);
        }
    }
}

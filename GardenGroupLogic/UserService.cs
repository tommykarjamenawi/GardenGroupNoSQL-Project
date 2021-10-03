using GardenGroupDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogic
{
    public class UserService : BaseDAO
    {
        public UserService()
        {

        }

        public bool CheckUser(string lastName)
        {
            return db.GetUsersCollection(lastName);
        }
    }
}

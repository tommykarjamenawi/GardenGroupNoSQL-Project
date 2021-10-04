using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class LoginSession
    {
        private static LoginSession uniqueInstance;
        private User userLoggedIn;
        public static LoginSession GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new LoginSession();
            return uniqueInstance;
        }

        public User LoggedIn
        {
            get
            {
                return userLoggedIn;
            }
            set
            {
                if (userLoggedIn == null)
                    userLoggedIn = value;
            }
        }
    }
}

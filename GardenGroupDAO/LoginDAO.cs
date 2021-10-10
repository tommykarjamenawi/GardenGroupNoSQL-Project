using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAO
{
    public class LoginDAO : MongoDB
    {
        public void AddRememberMe(RememberMe user)
        {
            InsertDocument<RememberMe>("RememberCredentials", user);
        }

        public List<RememberMe> CheckRememberMe()
        {
            return GetDocuments<RememberMe>("RememberCredentials");
        }
    }
}

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

        public List<RememberMe> OverWriteRememberMe()
        {
            return GetDocuments<RememberMe>("RememberCredentials");
        }

        public void OverWriteRememberMe(RememberMe record)
        {
            var collection = db.GetCollection<RememberMe>("RememberCredentials");
            var filter = Builders<RememberMe>.Filter.Eq("ProcessorSerial", record.ProcessorSerial);
            var update1 = Builders<RememberMe>.Update.Set("email", record.email);
            var update2 = Builders<RememberMe>.Update.Set("password", record.password);
            collection.UpdateOne(filter, update1);
            collection.UpdateOne(filter, update2);
        }
    }
}

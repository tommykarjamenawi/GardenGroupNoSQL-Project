using GardenGroupModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupDAO
{
    public class UserArchiveDAO:MongoDB
    {
        readonly string COLLECTION_NAME = "UserArchive";
        public List<User> GetAllArchivedUsers()
        {
            IMongoCollection<User> userCollection = db.GetCollection<User>(COLLECTION_NAME);
            return userCollection.AsQueryable().ToList<User>();
        }
        public void AddUserToArchive(User user)
        {
            InsertDocument<User>(COLLECTION_NAME, user);
        }
        public void RemoveUserArchive(User user)
        {
            DeleteDocument<User>(user.Id, COLLECTION_NAME);
        }
    }
}

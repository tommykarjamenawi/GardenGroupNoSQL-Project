using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GardenGroupModel
{
    public class User
    {    
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("FirstName")]
        public string FirstName { get; set; }
        [BsonElement("LastName")]
        public string LastName { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Branch")]
        public string branch { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("TypeOfUser")]
        public string TypeOfUser { get; set; }
        [BsonElement("salt")]
        public string salt { get; set; }


        [BsonConstructor]
        public User()
        {

        }

        
       
    }
}
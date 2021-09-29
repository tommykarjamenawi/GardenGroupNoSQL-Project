using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupUI
{
    class User
    {
        
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("First name")]
        public string FirstName { get; set; }
        [BsonElement("Last name")]
        public string LastName { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Branch")]
        public string Branch { get; set; }
        [BsonElement("Phone number")]
        public string Phone { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("Type of user")]
        public Enums.TypeOfUser TypeOfUser { get; set; }


        [BsonConstructor]
        public User(string FirstName, string LastName, string Email, string Branch, string Phone, string Password, Enums.TypeOfUser TypeOfUser)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Branch = Branch;
            this.Phone = Phone;
            this.Password = Password;
            this.TypeOfUser = TypeOfUser;
        }

    }
}

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
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Branch { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Enums.TypeOfUser TypeOfUser{get; set;}


        [BsonConstructor]
        public User(ObjectId Id, string FirstName, string LastName, string Email, string Branch, string Phone, string Password, Enums.TypeOfUser TypeOfUser)
        {
            this.Id = Id;
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

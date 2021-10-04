﻿using MongoDB.Bson.Serialization.Attributes;
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
        public string Branch { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("TypeOfUser")]
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
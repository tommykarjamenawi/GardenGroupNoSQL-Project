using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GardenGroupModel
{
    public class RememberMe
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("email")]
        public string email { get; set; }
        [BsonElement("password")]
        public string password { get; set; }
        [BsonElement("HddSerial")]
        public string HddSerial { get; set; }
        [BsonElement("ProcessorSerial")]
        public string ProcessorSerial { get; set; }

        [BsonConstructor]
        public RememberMe(string email, string password, string HddSerial, string ProcessorSerial)
        {
            this.email = email;
            this.password = password;
            this.HddSerial = HddSerial;
            this.ProcessorSerial = ProcessorSerial;
        }
        [BsonConstructor]
        public RememberMe()
        {

        }


    }
}

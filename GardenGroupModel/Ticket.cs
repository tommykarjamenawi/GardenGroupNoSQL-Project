using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupModel
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Subject")]
        public string Subject { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("ReportedDate")]
        public DateTime ReportedDate { get; set; }
        [BsonElement("ReportedBy")]
        public string ReportedBy { get; set; }
        [BsonElement("Deadline")]
        public DateTime Deadline { get; set; }
        [BsonElement("TypeOfIncident")]
        public string TypeOfIncident { get; set; }
        [BsonElement("TypeOfPriority")]
        public string TypeOfPriority { get; set; }
        [BsonElement("Solved")]
        public bool IsSolved { get; set; }

        [BsonConstructor]
        public Ticket(string Subject, string Description, DateTime ReportedDate, string ReportedBy, DateTime Deadline, Enums.TypeOfIncident TypeOfIncident, Enums.TypeOfPriority TypeOfPriority)
        {
            this.Subject = Subject;
            this.Description = Description;
            this.ReportedDate = ReportedDate;
            this.ReportedBy = ReportedBy;
            this.Deadline = Deadline;
            this.TypeOfIncident = TypeOfIncident.ToString();
            this.TypeOfPriority = TypeOfPriority.ToString();
            IsSolved = false;
        }


        public Ticket() { }

    }
}

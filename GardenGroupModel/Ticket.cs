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
        [BsonElement("IsSolved")]
        public bool IsSolved { get; set; }

        public Ticket(DateTime ReportedDate, string Subject, Enums.TypeOfIncident TypeOfIncident, string ReportedBy, Enums.TypeOfPriority TypeOfPriority, DateTime Deadline, string Description)
        {
            this.ReportedDate = ReportedDate;
            this.Subject = Subject;
            this.TypeOfIncident = TypeOfIncident.ToString();
            this.ReportedBy = ReportedBy;
            this.TypeOfPriority = TypeOfPriority.ToString();
            this.Deadline = Deadline;
            this.Description = Description;         
            
            IsSolved = false;
        }


        public Ticket() { }

    }
}

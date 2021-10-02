using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using GardenGroupModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace GardenGroupDAO
{
    public class TicketDAO
    {
        private IMongoCollection<Ticket> collection;
        public TicketDAO()
        {
            //MongoClient connection = MongoDB.GetInstance();
            //IMongoDatabase db = connection.GetDatabase("GardenGroup");
            //collection = db.GetCollection<Ticket>("Tickets");
        }

        public List<Ticket> GetTickets()
        {
            IFindFluent<Ticket, Ticket> tickets = GetAllTickets();
            var results = new List<Ticket>();

            foreach (var item in tickets.ToList())
            {
                var ticket = new Ticket()
                {
                    Id = item.Id,
                    ReportedBy = item.ReportedBy,
                    Subject = item.Subject,
                    TypeOfIncident = (Enums.TypeOfIncident)item.TypeOfIncident,
                    TypeOfPriority = (Enums.TypeOfPriority)item.TypeOfPriority,
                    ReportedDate = item.ReportedDate,
                    Deadline = item.Deadline,
                    Description = item.Description,
                    IsSolved = item.IsSolved,                                     
                };
                results.Add(ticket);
            }
            return results;
        }

        public IFindFluent<Ticket, Ticket> GetAllTickets()
        {
            var allTickets = collection.Find(i => true);
            return allTickets;
        }

    }
}

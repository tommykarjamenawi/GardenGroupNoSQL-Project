using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupModel;
using MongoDB.Driver;

namespace GardenGroupDAO
{
   public class TicketArchiveDAO:MongoDB
    {
        readonly string COLLECTION_NAME = "TicketArchive";
        public List<Ticket> GetAllArchivedTickets()
        {
            IMongoCollection<Ticket> userCollection = db.GetCollection<Ticket>(COLLECTION_NAME);
            return userCollection.AsQueryable().ToList<Ticket>();
        }

        public List<Ticket> GetAllArchivedTicketsForUser(User user)
        {
            IMongoCollection<Ticket> userCollection = db.GetCollection<Ticket>(COLLECTION_NAME);
            return userCollection.Find<Ticket>(Ticket => Ticket.ReportedBy.Email == user.Email).ToList<Ticket>();
        }
        public void AddTicketToArchive(Ticket ticket)
        {
            InsertDocument<Ticket>(COLLECTION_NAME, ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            DeleteDocument<Ticket>(ticket.Id, COLLECTION_NAME);
        }
    }
}

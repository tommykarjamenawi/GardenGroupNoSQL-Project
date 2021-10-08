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
    public class TicketDAO : MongoDB
    {
        private readonly string TABLE_NAME = "Tickets";
        public TicketDAO()
        {
            //MongoClient connection = MongoDB.GetInstance();
            //IMongoDatabase db = connection.GetDatabase("GardenGroup");
            //collection = db.GetCollection<Ticket>("Tickets");
        }

        public void AddTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = db.GetCollection<Ticket>(TABLE_NAME);
            collection.InsertOne(ticket);
        }

        // tickets for one specific user
        public List<Ticket> GetAllTicketsForUser(User user)
        {
           // var tickets = GetDocuments<Ticket>(TABLE_NAME);
            //return = tickets.Find<Ticket>(Ticket => Ticket.ReportedBy == user.FirstName).ToList<Ticket>();
            IMongoCollection<Ticket> collection = db.GetCollection<Ticket>(TABLE_NAME);
            return collection.Find<Ticket>(Ticket => Ticket.ReportedBy == user.FirstName).ToList<Ticket>();
        }

        // all tickets for an admin
        public List<Ticket> GetAllTickets()
        {
            IMongoCollection<Ticket> collection = db.GetCollection<Ticket>(TABLE_NAME);
            return collection.AsQueryable().ToList<Ticket>();

            //List<Ticket> tickets = GetDocuments<Ticket>(TABLE_NAME);
            //return tickets;
        }

        public List<Ticket> GetAllSortedById()
        {
            return GetSortedIDDocuments<Ticket>(TABLE_NAME);
        }

        public List<Ticket> GetUsersTicketsSortedByID(User user)
        {
            return GetUsersTicketsSortedByIDDocuments<Ticket>(TABLE_NAME, user);
        }

        public List<Ticket> GetUsersTicketsSortedByPriority(User user)
        {
            return GetUsersTicketsSortedByPriorityDocuments<Ticket>(TABLE_NAME, user);
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            return GetSortedPriorityDocuments<Ticket>(TABLE_NAME);
        }

        public void UpdateTicket(ObjectId id, Ticket updatedTicket)
        {
            UpdateDocument<Ticket>(id, TABLE_NAME, updatedTicket);
        }

        public void DeleteTicket(ObjectId id)
        {
            DeleteDocument<Ticket>(id, TABLE_NAME);
        }
    }
}

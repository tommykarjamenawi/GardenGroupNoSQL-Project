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
        private IMongoCollection<Ticket> collection;
        public TicketDAO()
        {

        }

        public void AddTicket(Ticket ticket)
        {
            collection = db.GetCollection<Ticket>(TABLE_NAME);
            collection.InsertOne(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            collection = db.GetCollection<Ticket>(TABLE_NAME);
            var filter = Builders<Ticket>.Filter.Eq("Id", ticket.Id);
            collection.DeleteOne(filter);
        }

        // tickets for one specific user
        public List<Ticket> GetAllTicketsForUser(User user)
        {
            collection = db.GetCollection<Ticket>(TABLE_NAME);
            return collection.Find<Ticket>(Ticket => Ticket.ReportedBy.Email == user.Email).ToList<Ticket>();
        }

        // all tickets for an admin
        public List<Ticket> GetAllTickets()
        {
            collection = db.GetCollection<Ticket>(TABLE_NAME);
            return collection.AsQueryable().ToList<Ticket>();
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

        public void UpdateTicket(Ticket ticket)
        {
            collection = db.GetCollection<Ticket>(TABLE_NAME);
            var filter = Builders<Ticket>.Filter.Eq("Id", ticket.Id);
            collection.ReplaceOne(filter, ticket, new ReplaceOptions() { IsUpsert = true });
        }

        public void ChangeStatus(Ticket ticket)
        {
            collection = db.GetCollection<Ticket>(TABLE_NAME);
            var update = Builders<Ticket>.Update.Set("IsSolved", true);
            collection.UpdateOne<Ticket>(Ticket => Ticket.Id == ticket.Id, update);
        }
    }
}

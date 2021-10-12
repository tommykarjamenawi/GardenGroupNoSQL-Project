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
            // finds the collect of tickets and also assigns it to every method in DAOS
            collection = db.GetCollection<Ticket>(TABLE_NAME);
        }

        public void AddTicket(Ticket ticket)
        {
            collection.InsertOne(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq("Id", ticket.Id);
            collection.DeleteOne(filter);
        }

        // tickets for one specific user
        public List<Ticket> GetAllTicketsForUser(User user)
        {
            return collection.Find<Ticket>(Ticket => Ticket.ReportedBy.Email == user.Email).ToList<Ticket>();
        }

        // all tickets for an admin
        public List<Ticket> GetAllTickets()
        {
            return collection.AsQueryable().ToList<Ticket>();
        }

        public void UpdateTicket(Ticket ticket)
        {
            var filter = Builders<Ticket>.Filter.Eq("Id", ticket.Id);
            collection.ReplaceOne(filter, ticket, new ReplaceOptions() { IsUpsert = true });
        }

        public void ChangeStatus(Ticket ticket)
        {
            var update = Builders<Ticket>.Update.Set("IsSolved", true);
            collection.UpdateOne<Ticket>(Ticket => Ticket.Id == ticket.Id, update);
        }

        public List<Ticket> GetUserSortedById(User user)
        {
            var filter = Builders<Ticket>.Filter.Eq("Id", user.Id);
            var sort = Builders<Ticket>.Sort.Descending("Id");

            return collection.Find(filter).Sort(sort).ToList();
        }

        public List<Ticket> GetAllSortedById()
        {
            var sort = Builders<Ticket>.Sort.Descending("Id");

            return collection.Find<Ticket>(new BsonDocument()).Sort(sort).ToList();
        }

        public List<Ticket> GetUserSortedPriority(User user)
        {
            var filter = Builders<Ticket>.Filter.Eq("ReportedBy", user.Id);
            var prioritySort = Builders<Ticket>.Sort.Descending("Priority");
            var reportSort = Builders<Ticket>.Sort.Descending("ReportedDate");

            return collection.Find(filter).Sort(reportSort).Sort(prioritySort).ToList();
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            var prioritySort = Builders<Ticket>.Sort.Descending("Priority");
            var reportedDateSort = Builders<Ticket>.Sort.Descending("ReportedDate");

            return collection.Find<Ticket>(new BsonDocument()).Sort(reportedDateSort).Sort(prioritySort).ToList();
        }

        public List<Ticket> GetUserSortedByReportedDate(User user)
        {
            var filter = Builders<Ticket>.Filter.Eq("ReportedBy", user.Id);
            var sort = Builders<Ticket>.Sort.Ascending("ReportedDate");
            return collection.Find<Ticket>(filter).Sort(sort).ToList();
        }

        public List<Ticket> GetAllSortedByReportedDate()
        { 
            var sort = Builders<Ticket>.Sort.Ascending("ReportedDate");
            return collection.Find<Ticket>(new BsonDocument()).Sort(sort).ToList();
        }
    }
}

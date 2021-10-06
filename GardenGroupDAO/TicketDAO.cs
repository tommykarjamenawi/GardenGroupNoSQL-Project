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

        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = GetDocuments<Ticket>(TABLE_NAME);
            return tickets;
        }

        public List<Ticket> GetAllSortedById()
        {
            return GetSortedIDDocuments<Ticket>(TABLE_NAME);
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            return GetSortedPriorityDocuments<Ticket>(TABLE_NAME);
        }

        public void CreateTicket(Ticket newTicket)
        {
            InsertDocument<Ticket>(TABLE_NAME, newTicket);
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

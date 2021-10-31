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
        public void AddTicketToArchive(Ticket ticket)
        {
            InsertDocument<Ticket>(COLLECTION_NAME, ticket);
        }
    }
}

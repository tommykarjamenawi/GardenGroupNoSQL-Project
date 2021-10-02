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
            MongoClient connection = BaseDAO.GetInstance();
        }

    }
}

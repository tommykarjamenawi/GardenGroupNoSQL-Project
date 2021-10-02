using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupDAO;
using GardenGroupModel;

namespace GardenGroupLogic
{
    public class TicketService
    {
        private TicketDAO db;
        private List<Ticket> tickets;

        public TicketService()
        {
            db = new TicketDAO();
        }

        public List<Ticket> GetTickets()
        {
            return db.GetTickets();
        }

    }
}

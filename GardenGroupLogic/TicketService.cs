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
        private List<Ticket> tickets;
        private TicketDAO ticketDAO;

        public TicketService()
        {

        }
        public List<Ticket> GetAllSortedById()
        {
            return ticketDAO.GetAllSortedById();
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            return ticketDAO.GetAllSortedByPriority();
        }

    }
}

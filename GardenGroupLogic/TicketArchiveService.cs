using GardenGroupDAO;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogic
{
  public  class TicketArchiveService
    {
        TicketArchiveDAO tickettArchiveDAO =  new TicketArchiveDAO();
        public List<Ticket> GetAllArchivedTickets()
        {
            return tickettArchiveDAO.GetAllArchivedTickets();
        }
        public void AddTicketToArchive(Ticket ticket)
        {
            tickettArchiveDAO.AddTicketToArchive(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            tickettArchiveDAO.RemoveTicket(ticket);
        }

        public List<Ticket> GetAllArchivedTicketsForUser(User user)
        {
            return tickettArchiveDAO.GetAllArchivedTicketsForUser(user);
        }
    }
}

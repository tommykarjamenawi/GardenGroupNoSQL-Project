using GardenGroupDAO;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenGroupLogic
{
    class TicketArchiveService
    {
        TicketArchiveDAO tickettArchiveDAO;
        public List<Ticket> GetAllArchivedTickets()
        {
            return tickettArchiveDAO.GetAllArchivedTickets();
        }
        public void AddTicketToArchive(Ticket ticket)
        {
            tickettArchiveDAO.AddTicketToArchive(ticket);
        }
    }
}

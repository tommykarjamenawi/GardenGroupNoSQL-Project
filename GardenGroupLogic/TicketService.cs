using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenGroupDAO;
using GardenGroupModel;
using MongoDB.Bson;

namespace GardenGroupLogic
{
    public class TicketService
    {
        private List<Ticket> tickets;
        private TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }
        public List<Ticket> GetAllSortedById()
        {
            return ticketDAO.GetAllSortedById();
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            return ticketDAO.GetAllSortedByPriority();
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDAO.GetAllTickets();
        }

        public void CreateTicket(Ticket newTicket)
        {
            ticketDAO.CreateTicket(newTicket);
        }

        // check the update ticket later
        public void UpdateTicketCheck(Ticket ticket)
        {
            if (ticket.Id == null)
                return;
            ticketDAO.UpdateTicket(ticket.Id, ticket);
        }

        public void UpdateTicket(ObjectId id, Ticket ticket)
        {
            ticket.Id = id;
            UpdateTicketCheck(ticket);
        }

        public void DeleteTicket(ObjectId id)
        {
            ticketDAO.DeleteTicket(id);
        }
    }
}

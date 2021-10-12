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
        private TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public void AddTicket(Ticket ticket)
        {
            ticketDAO.AddTicket(ticket);
        }

        public void RemoveTicket(Ticket ticket)
        {
            ticketDAO.RemoveTicket(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            ticketDAO.UpdateTicket(ticket);
        }

        public void ChangeStatus(Ticket ticket)
        {
            ticketDAO.ChangeStatus(ticket);
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDAO.GetAllTickets();
        }

        public List<Ticket> GetAllTicketsForUser(User user)
        {
            return ticketDAO.GetAllTicketsForUser(user);
        }

        public List<Ticket> GetAllSortedById()
        {
            return ticketDAO.GetAllSortedById();
        }

        public List<Ticket> GetUserSortedById(User user)
        {
            return ticketDAO.GetUserSortedById(user);
        }

        public List<Ticket> GetAllSortedByPriority()
        {
            return ticketDAO.GetAllSortedByPriority();
        }
        public List<Ticket> GetUserSortedByPriority(User user)
        {
            return ticketDAO.GetUserSortedPriority(user);
        }

        public List<Ticket> GetUsersSortedByReportedDate(User user)
        {
            return ticketDAO.GetUserSortedByReportedDate(user);
        }

        public List<Ticket> GetAllSortedByReportedDate()
        {
            return ticketDAO.GetAllSortedByReportedDate();
        }
    }
}

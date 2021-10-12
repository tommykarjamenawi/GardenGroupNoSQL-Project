using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;

namespace GardenGroupUI
{
    public partial class TicketOverviewForm : Form
    {
        private List<Ticket> tickets;
        private TicketService ticketService;
        private User user;
        public TicketOverviewForm(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            InitializeComponent();
        }

        private void TicketOverviewForm_Load(object sender, EventArgs e)
        {
            DisplayAllTickets();          
        }

        //private void CheckUserType()
        //{
        //    //check whether the logged in user is admin or an enduser and display tickets accordingly
        //    //user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString()


        //    DisplayAllTickets();
        //}

        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewTickets.SelectedIndices.Count > 0)
            {
                Ticket ticket = (Ticket)listViewTickets.SelectedItems[0].Tag;

                UpdateTicket ut = new UpdateTicket(ticket, user);
                ut.ShowDialog();
            }
        }

        public void DisplayAllTickets()
        {
                if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString()) // Enum.GetName(typeof(Enums.TypeOfUser),Enums.TypeOfUser.EndUser) // note: need == and NOT Equals!
                    tickets = ticketService.GetAllTicketsForUser(user);
                else
                    tickets = ticketService.GetAllTickets();

            listViewTickets.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.ReportedBy.Email.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.TypeOfIncident.ToString());
                item.SubItems.Add(ticket.TypeOfPriority.ToString());
                item.SubItems.Add(ticket.ReportedDate.ToString());
                item.SubItems.Add(ticket.Deadline.ToString());
                item.SubItems.Add(ticket.Description);
                item.SubItems.Add(ticket.IsSolved.ToString());
                item.Tag = ticket;
                listViewTickets.Items.Add(item);

            }
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket(user);
            addTicket.ShowDialog();
        }


        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedListSort();
        }

        public void ChangedListSort()
        {
            string sortBy = cmbSortBy.Text;

            List<Ticket> sortedList = tickets;

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                if (sortBy == "ID")
                {
                    sortedList = ticketService.GetUserSortedById(user);
                }
                else if (sortBy == "Priority")
                {
                    sortedList = ticketService.GetUserSortedByPriority(user);
                }
                else if (sortBy == "Reported date")
                {
                    sortedList = ticketService.GetUsersSortedByReportedDate(user);
                }
            }
            else
            {
                if (sortBy == "ID")
                {
                    sortedList = ticketService.GetAllSortedById();
                }
                else if(sortBy == "Priority")
                {
                    sortedList = ticketService.GetAllSortedByPriority();
                }
                else if (sortBy == "Reported date")
                {
                    sortedList = ticketService.GetAllSortedByReportedDate();
                }
            }

            listViewTickets.Items.Clear();

            tickets = sortedList;
            DisplayAllTickets();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAllTickets();
        }
    }
}

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
            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                lblUser.Text = user.FirstName + user.LastName;
                lblTypeOfUser.Text = user.TypeOfUser;
            }
            else
            {
                lblUser.Text = user.FirstName + user.LastName;
                lblTypeOfUser.Text = user.TypeOfUser;
            }
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
            string sortBy = cmbSortBy.Text;
            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                if (sortBy == "ID")
                    tickets = ticketService.GetUserSortedById(user);
                else 
                if (sortBy == "Priority")
                    tickets = ticketService.GetUserSortedByPriority(user);
                else 
                if (sortBy == "Reported date")
                    tickets = ticketService.GetUsersSortedByReportedDate(user);
                else // default is Not sorted
                    tickets = ticketService.GetAllTicketsForUser(user);
            }
            else
            {
                if (sortBy == "ID")
                    tickets = ticketService.GetAllSortedById();
                else 
                if (sortBy == "Priority")
                    tickets = ticketService.GetAllSortedByPriority();
                else 
                if (sortBy == "Reported date")
                    tickets = ticketService.GetAllSortedByReportedDate();
                else // default is Not sorted
                    tickets = ticketService.GetAllTickets();
            }

            // if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString()) // Enum.GetName(typeof(Enums.TypeOfUser),Enums.TypeOfUser.EndUser) // note: need == and NOT Equals!

 
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
                item.SubItems.Add(ticket.IsSolved.ToString());
                item.SubItems.Add(ticket.Description);
                item.Tag = ticket;
                listViewTickets.Items.Add(item);
                listViewTickets.Columns[8].Width = -2;

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
            DisplayAllTickets();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAllTickets();
        }
    }
}

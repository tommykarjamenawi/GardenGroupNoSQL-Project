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
        private List<User> users;
        private User user;
        public TicketOverviewForm(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            InitializeComponent();

            var pack = new ConventionPack
            {
              new EnumRepresentationConvention(BsonType.String)
            };
        }

        private void TicketOverviewForm_Load(object sender, EventArgs e)
        {
            //check whether the logged in user is admin or an enduser and display tickets accordingly
            if (user.TypeOfUser.Equals(Enums.TypeOfUser.ServiceDeskEmployee))
            {
                tickets = ticketService.GetAllTickets();
            }
            else
            {
                tickets = ticketService.GetAllTicketsForUser(user);
            }
            DisplayAllTickets();
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count <= 0)
                return;

            btnUpdate.Enabled = listViewTickets.SelectedItems.Count > 0;
        }

        public void DisplayAllTickets()
        {
            listViewTickets.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.ReportedBy.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.TypeOfIncident);
                item.SubItems.Add(ticket.TypeOfPriority);
                item.SubItems.Add(ticket.ReportedDate.ToString());
                item.SubItems.Add(ticket.Deadline.ToString());
                item.SubItems.Add(ticket.Description);
                item.SubItems.Add(ticket.IsSolved.ToString());
                listViewTickets.Items.Add(item);
            }
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket();
            addTicket.Show();
            this.Hide();
        }


        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedListSort();
        }

        public void ChangedListSort()
        {
            string sortBy = cmbSortBy.Text;

            List<Ticket> sortedList = tickets;

            if (user.TypeOfUser.Equals(Enums.TypeOfUser.EndUser))
            {
                if (sortBy == "ID")
                {
                    sortedList = ticketService.GetFromUserSortedById(user);
                }
                else if (sortBy == "Priority")
                {
                    sortedList = ticketService.GetFromUserSortedByPriority(user);
                }
            }
            else
            {
                if (sortBy == "ID")
                {
                    sortedList = ticketService.GetAllSortedById();
                }
                else
                {
                    sortedList = ticketService.GetAllSortedByPriority();
                }
            }

            listViewTickets.Items.Clear();

            tickets = sortedList;
            DisplayAllTickets();
        }
    }
}

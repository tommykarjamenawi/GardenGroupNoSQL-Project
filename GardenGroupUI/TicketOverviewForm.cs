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
        private User userLoggedIn;
        public TicketOverviewForm()
        {
            InitializeComponent();

            var pack = new ConventionPack
            {
              new EnumRepresentationConvention(BsonType.String)
            };
        }

        private void TicketOverviewForm_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count <= 0)
                return;
        }

        private void LoadDetails()
        {
            DisplayAllTickets();
        }

        public void DisplayAllTickets()
        {
            listViewTickets.Items.Clear();
            List<Ticket> tickets = ticketService.GetAllTickets();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.ReportedBy.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.TypeOfIncident.ToString());
                item.SubItems.Add(ticket.TypeOfPriority.ToString());
                item.SubItems.Add(ticket.ReportedDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(ticket.Deadline.ToString());
                item.SubItems.Add(ticket.Description.ToString());
                item.SubItems.Add(ticket.IsSolved.ToString());
                listViewTickets.Items.Add(item);
            }
        }

        public void DisplayAllTickets2()
        {
            userLoggedIn = LoginSession.GetInstance().LoggedIn;


        }



        private string ReportedByFullName(int id)
        {
            string reportedFullName = "";

            foreach(User user in users)
            {
                if (id.Equals(user.Id))
                {
                    reportedFullName = user.FirstName + user.LastName;
                    break;
                }
            }
            return reportedFullName;
        }


    }
}

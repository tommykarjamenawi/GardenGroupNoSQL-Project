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

            foreach (Ticket ticketItems in tickets)
            {
                ListViewItem item = new ListViewItem(ticketItems.Id.ToString());
                item.SubItems.Add(ticketItems.ReportedBy.ToString());
                item.SubItems.Add(ticketItems.Subject);
                item.SubItems.Add(ticketItems.TypeOfIncident.ToString());
                item.SubItems.Add(ticketItems.TypeOfPriority.ToString());
                item.SubItems.Add(ticketItems.ReportedDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(ticketItems.Deadline.ToString());
                item.SubItems.Add(ticketItems.Description.ToString());
                item.SubItems.Add(ticketItems.IsSolved.ToString());
                listViewTickets.Items.Add(item);


                //this.Subject = Subject;
                //this.Description = Description;
                //this.ReportedDate = ReportedDate;
                //this.ReportedBy = ReportedBy;
                //this.Deadline = Deadline;
                //this.TypeOfIncident = TypeOfIncident;
                //this.TypeOfPriority = TypeOfPriority;
                //IsSolved = false;
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

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

namespace GardenGroupUI
{
    public partial class TicketOverviewForm : Form
    {
        private List<Ticket> tickets;
        private TicketService ticketService;

        public TicketOverviewForm()
        {
            InitializeComponent();
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
                   item.SubItems.Add(ticketItems.Subject);
                   item.SubItems.Add(ticketItems.ReportedBy.ToString());
                   item.SubItems.Add(ticketItems.ReportedDate.ToString("dd-MM-yyyy"));
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


    }
}

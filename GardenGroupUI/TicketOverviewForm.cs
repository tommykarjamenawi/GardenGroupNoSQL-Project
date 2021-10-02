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

        Ticket Ticket;
        User User;
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
            if (listViewItems.SelectedItems.Count <= 0)
                return;

        }

        private void LoadDetails()
        {
            foreach (Ticket ticket in Ticket.TicketList) 
            {
                ListViewItem item = new ListViewItem(Ticket.Id.ToString());
                item.SubItems.Add(Ticket.Subject);
                item.SubItems.Add(Ticket.ReportedBy.ToString());
                item.SubItems.Add(Ticket.ReportedDate.ToString());
                item.SubItems.Add(Ticket.IsSolved.ToString());
                listViewItems.Items.Add(item);
            }
        }

        
    }
}

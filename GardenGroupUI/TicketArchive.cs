using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class TicketArchive : Form
    {
        List<Ticket> tickets;
        TicketArchiveService ticketArchiveService = new TicketArchiveService();
        User user;
        public TicketArchive(User user)
        {
            InitializeComponent();
            this.user = user;
            FillForm();
            lblEmailSignedIn.Text = user.Email;
        }

        void FillForm()
        {
            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                tickets = ticketArchiveService.GetAllArchivedTicketsForUser(user);
                btnManageUser.Visible = false;
            }
               

            else
                tickets = ticketArchiveService.GetAllArchivedTickets();

            foreach (Ticket t in tickets)
            {
                ListViewItem li = new ListViewItem(t.Id.ToString());
                li.SubItems.Add(t.ReportedBy.Email.ToString());
                li.SubItems.Add(t.Subject);
                li.SubItems.Add(t.TypeOfIncident.ToString());
                li.SubItems.Add(t.TypeOfPriority.ToString());
                li.SubItems.Add(t.ReportedDate.ToString());
                li.SubItems.Add(t.Deadline.ToString());
                li.SubItems.Add(t.IsSolved.ToString());
                li.SubItems.Add(t.Description.ToString());
                li.Tag = t;
                listViewTickets.Items.Add(li);
            }
        }

        private void btnTicketOverview_Click_1(object sender, EventArgs e)
        {
            TicketOverviewForm ticketOverviewForm = new TicketOverviewForm(user);
            this.Hide();
            ticketOverviewForm.ShowDialog();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            TicketOverviewStatistics ticketOverviewStatistics = new TicketOverviewStatistics(user);
            this.Hide();
            ticketOverviewStatistics.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            this.Hide();
            ls.ShowDialog();
        }
    }
}

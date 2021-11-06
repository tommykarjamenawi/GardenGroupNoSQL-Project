using GardenGroupLogic;
using GardenGroupModel;
using MongoDB.Bson;
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
    public partial class UpdateTicket : Form
    {
        private TicketService ticketService;
        private UserService userService;
        private Ticket ticket;
        private User user;
        private DateTime DateTimeReported;
        public UpdateTicket(Ticket ticket, User user)
        {
            this.ticket = ticket;
            this.user = user;
            userService = new UserService();
            ticketService = new TicketService();
            InitializeComponent();
            DateTimeReported = DateTime.Now;
            txtDateReported.Text = DateTimeReported.ToString();
        }


        private void UpdateTicket_Load(object sender, EventArgs e)
        {
            lblEmailSignedIn.Text = user.Email;

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                btnStatus.Enabled = false;
                btnManageUser.Hide();
            }
            else
            {
                btnStatus.Enabled = true;
            }
            ShowTicket();
        }

        private void ShowTicket()
        {
            txtDateReported.Enabled = false;
            DateTimeReported = ticket.ReportedDate;
            txtSubject.Text = ticket.Subject;
            txtUser.Enabled = false;


            // this two lines are the reason i lost my mind
            cmbTypeOfIncident.DataSource = Enum.GetValues(typeof(Enums.TypeOfIncident));
            cmbTypeOfPriority.DataSource = Enum.GetValues(typeof(Enums.TypeOfPriority));



            cmbTypeOfIncident.Text = ticket.TypeOfIncident.ToString();
            txtUser.Text = ticket.ReportedBy.Email;
            cmbTypeOfPriority.Text = ticket.TypeOfPriority.ToString();
            dtpDeadline.Value = ticket.Deadline;
            txtDescription.Text = ticket.Description;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketOverviewForm tof = new TicketOverviewForm(user);
            tof.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ticket?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ticketService.RemoveTicket(this.ticket);
                MessageBox.Show($"Ticket {ticket.Id} has been removed!");
                this.Hide();
                TicketOverviewForm tof = new TicketOverviewForm(user);
                tof.ShowDialog();
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            this.ticket.IsSolved = true;
            ticketService.ChangeStatus(this.ticket);
            MessageBox.Show($"Ticket {ticket.Id} has been solved!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //updating the replaced values to db and listview
            this.ticket.Subject = txtSubject.Text;
            this.ticket.TypeOfIncident = (Enums.TypeOfIncident)Enum.Parse(typeof(Enums.TypeOfIncident), cmbTypeOfIncident.Text);
            this.ticket.Deadline = dtpDeadline.Value;
            this.ticket.TypeOfPriority = (Enums.TypeOfPriority)Enum.Parse(typeof(Enums.TypeOfPriority), cmbTypeOfPriority.Text);
            this.ticket.Description = txtDescription.Text;

            if (txtSubject.Text == "")
            {
                MessageBox.Show("Please fill out the subject");
                return;
            }

            if (cmbTypeOfIncident.SelectedIndex <= -1)
            {
                MessageBox.Show("Please fill out the type of incident");
                return;
            }

            if (cmbTypeOfPriority.SelectedIndex <= -1)
            {
                MessageBox.Show("Please fill out the priority level");
                return;
            }

            if (dtpDeadline.Value <= DateTime.Now)
            {
                MessageBox.Show("Please fill out a proper deadline (has to be bigger than the current date/time)");
                return;
            }

            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please fill out the description");
                return;
            }

            ticketService.UpdateTicket(this.ticket);
            MessageBox.Show($"Ticket {ticket.Id} has been updated!");
            this.Hide();
            TicketOverviewForm tof = new TicketOverviewForm(user);
            tof.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TicketOverviewStatistics ticketOverviewStatistics = new TicketOverviewStatistics(user);
            this.Hide();
            ticketOverviewStatistics.ShowDialog();
        }

        private void btnTicketOverview_Click(object sender, EventArgs e)
        {
            TicketOverviewForm ticketOverviewForm = new TicketOverviewForm(user);
            this.Hide();
            ticketOverviewForm.ShowDialog();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser(user);
            this.Hide();
            manageUser.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            this.Hide();
            ls.ShowDialog();
        }
    }


   
}

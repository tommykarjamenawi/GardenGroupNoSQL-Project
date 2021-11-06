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
using GardenGroupLogic;
using MongoDB.Bson;

namespace GardenGroupUI
{
    public partial class TransferTicket : Form
    {
        private User user;
        private Ticket ticket;
        private TicketService ticketService;
        private UserService userService;
        private List<User> users;
        private List<Ticket> tickets;
        public TransferTicket(User user, Ticket ticket)
        {
            this.user = user;
            this.ticket = ticket;
            ticketService = new TicketService();
            userService = new UserService();
            InitializeComponent();


        }

        private void TransferTicket_Load(object sender, EventArgs e)
        {
            users = userService.GetAllUsers();
            tickets = ticketService.GetAllTickets();

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                btnManageUser.Hide();
                txtCurrentUser.Text = ticket.ReportedBy.Email;
                lblLoggedinUser.Text = this.user.Email;

                cmbUser.DisplayMember = "Email";
                cmbUser.ValueMember = "Id";
                cmbUser.DataSource = users;

                cmbTicket.Items.Add(ticket.Id);

            }
            else
            {
                txtCurrentUser.Text = ticket.ReportedBy.Email;
                lblLoggedinUser.Text = this.user.Email;

                //foreach (User signinUser in users)
                //{
                //    cmbUser.Items.Add(signinUser.Email);
                //}

                cmbUser.DisplayMember = "Email";
                cmbUser.ValueMember = "Id";
                cmbUser.DataSource = users;

                foreach (Ticket ticket in tickets)
                {
                    cmbTicket.Items.Add(ticket.Id);
                }
            }     
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cmbTicket.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a ticket");
                return;
            }

            if (cmbUser.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a signinUser");
                return;
            }
   

            if (MessageBox.Show("Are you sure you want to transfer this ticket?", "Transfer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User user = userService.GetUserObjectById((ObjectId)cmbUser.SelectedValue);
                ticket.ReportedBy = user;
                ticketService.UpdateTicket(this.ticket);
                MessageBox.Show($"Ticket {ticket.Id} has been moved to {user.Email}!");
                this.Close();
            }
            
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

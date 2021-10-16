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
                txtCurrentUser.Text = ticket.ReportedBy.Email;
                lblLoggedinUser.Text = this.user.Email;

                foreach(User user in users)
                {
                    cmbUser.Items.Add(user.Email);
                }

                cmbTicket.Items.Add(ticket.Id);

            }
            else
            {
                txtCurrentUser.Text = ticket.ReportedBy.Email;
                lblLoggedinUser.Text = this.user.Email;

                foreach (User user in users)
                {
                    cmbUser.Items.Add(user.Email);
                }

                foreach (Ticket ticket in tickets)
                {
                    cmbTicket.Items.Add(ticket.Id);
                }
            }     
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to transfer this ticket?", "Transfer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User user = userService.GetUserObjectByEmail(cmbUser.Text);
                ticket.ReportedBy = user;
                ticketService.TransferTicket(this.ticket);
                MessageBox.Show($"Ticket {ticket.Id} has been moved to {user.Email}!");
                this.Close();
            }
            
        }
    }
}

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
        public UpdateTicket(Ticket ticket, User user)
        {
            this.ticket = ticket;
            this.user = user;
            userService = new UserService();
            ticketService = new TicketService();
            InitializeComponent();
        }


        private void UpdateTicket_Load(object sender, EventArgs e)
        {
            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                btnStatus.Enabled = false;
            }
            else
            {
                btnStatus.Enabled = true;
            }
            ShowTicket();
        }

        private void ShowTicket()
        {
            dtpDate.Enabled = false;
            dtpDate.Value = ticket.ReportedDate;
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
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this ticket?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.ticket.Id = (ObjectId)ticketService.RemoveTicket(ticket.Id);
                //this.ticket = (Ticket)
                ticketService.RemoveTicket(this.ticket);
                MessageBox.Show($"Ticket {ticket.Id} has been removed!");
                this.Close();
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

            ticketService.UpdateTicket(this.ticket);
            MessageBox.Show($"Ticket {ticket.Id} has been updated!");
            this.Close();
        }
    }


   
}

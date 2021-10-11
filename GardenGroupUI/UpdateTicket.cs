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
    public partial class UpdateTicket : Form
    {
        private TicketService ticketService;
        private Ticket ticket;
        private User user;
        public UpdateTicket(Ticket ticket)
        {
            this.ticket = ticket;
            this.user = user;
            ticketService = new TicketService();
            InitializeComponent();

        }

        private void ShowTicket()
        {
            dtpDate.Enabled = false;
            dtpDate.Value = ticket.ReportedDate;

            txtSubject.Text = ticket.Subject;
            cmbUser.Enabled = false;

            cmbTypeOfIncident.Text = ticket.TypeOfIncident.ToString();
            cmbUser.Text = ticket.ReportedBy.ToString();
            cmbTypeOfPriority.Text = ticket.TypeOfPriority.ToString();
            dtpDeadline.Value = ticket.Deadline;
            txtDescription.Text = ticket.Description;
        }


        private void UpdateTicket_Load(object sender, EventArgs e)
        {
            if (ticket == null)
            {
                if (ticket.ReportedBy.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
                {
                    btnStatus.Enabled = false;
                }
                else
                {
                    btnStatus.Enabled = true;
                }
            }
            ShowTicket();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ticketService.RemoveTicket(ticket.Id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ticketService.UpdateTicket(ticket);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ticketService.ChangeStatus(ticket);
            MessageBox.Show("Ticket has been solved!");

        }
    }
}

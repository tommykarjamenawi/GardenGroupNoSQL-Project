﻿using System;
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
        private User user;
        public TicketOverviewForm(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            InitializeComponent();
            btnTransfer.Enabled = false;
            btnStatistics.Enabled = false;
        }

        private void TicketOverviewForm_Load(object sender, EventArgs e)
        {
            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                lblUser.Text = user.FirstName + " " + user.LastName;
                lblTypeOfUser.Text = user.TypeOfUser;
                lblEmail.Text = user.Email;
            }
            else
            {
                btnStatistics.Enabled = true;
                lblUser.Text = user.FirstName + " " + user.LastName;
                lblTypeOfUser.Text = user.TypeOfUser;
                lblEmail.Text = user.Email;
            }
                DisplayAllTickets();          
        }

        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedIndices.Count > 0)
            {
                btnTransfer.Enabled = true;
            }
        }

        public void DisplayAllTickets()
        {
            string sortBy = cmbSortBy.Text;
            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                switch(sortBy)
                {
                    case "ID":
                        tickets = ticketService.GetUserSortedById(user);
                        break;
                    case "Priority":
                        tickets = ticketService.GetUserSortedByPriority(user);
                        break;
                    case "Reported date":
                        tickets = ticketService.GetUserSortedByReportedDate(user);
                        break;
                    case "Deadline":
                        tickets = ticketService.GetUserSortedByDeadline(user);
                        break;
                    case "Solved":
                        tickets = ticketService.GetUserSortedBySolved(user);
                        break;
                    default:
                        tickets = ticketService.GetAllTicketsForUser(user);
                            break;
                }
            }
            else
            {
                switch (sortBy)
                {
                    case "ID":
                        tickets = ticketService.GetAllSortedById();
                        break;
                    case "Priority":
                        tickets = ticketService.GetAllSortedByPriority();
                        break;
                    case "Reported date":
                        tickets = ticketService.GetAllSortedByReportedDate();
                        break;
                    case "Deadline":
                        tickets = ticketService.GetAllSortedByDeadline();
                        break;
                    case "Solved":
                        tickets = ticketService.GetAllSortedBySolved();
                        break;         
                    default:
                        tickets = ticketService.GetAllTickets();
                        break;
                 }
            }

            // if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString()) // Enum.GetName(typeof(Enums.TypeOfUser),Enums.TypeOfUser.EndUser) // note: need == and NOT Equals!

 
            listViewTickets.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.ReportedBy.Email.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.TypeOfIncident.ToString());
                item.SubItems.Add(ticket.TypeOfPriority.ToString());
                item.SubItems.Add(ticket.ReportedDate.ToString());
                item.SubItems.Add(ticket.Deadline.ToString());
                item.SubItems.Add(ticket.IsSolved.ToString());
                item.SubItems.Add(ticket.Description);
                item.Tag = ticket;
                listViewTickets.Items.Add(item);
                listViewTickets.Columns[8].Width = -2;

            }
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket(user);
            addTicket.ShowDialog();
        }


        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangedListSort();
        }

        public void ChangedListSort()
        {
            DisplayAllTickets();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAllTickets();
        }

        private void listViewTickets_DoubleClick(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedIndices.Count > 0)
            {
                Ticket ticket = (Ticket)listViewTickets.SelectedItems[0].Tag;

                UpdateTicket ut = new UpdateTicket(ticket, user);
                ut.ShowDialog();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count <= 0)
            {
               if (MessageBox.Show("Please select a ticket to transfer", "Select ticket", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    return;
                }
            }
 
      
            Ticket ticket = (Ticket)listViewTickets.SelectedItems[0].Tag;

            TransferTicket tt = new TransferTicket(user, ticket);
            tt.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            this.Hide();
            ls.ShowDialog();

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
                TicketOverviewStatistics tos = new TicketOverviewStatistics(user);
                this.Hide();
                tos.ShowDialog();
        }
    }
}

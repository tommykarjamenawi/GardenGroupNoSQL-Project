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

namespace GardenGroupUI
{
    public partial class AddTicket : Form
    {
        private Ticket ticket;
        private TicketService ticketService;
        private UserService userService;
        private List<User> users;
        private User user;
        public AddTicket(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            userService = new UserService();

            InitializeComponent();
            btnAdd.Enabled = false;
        }
        private void CleanForm()
        {
            dtpDate.Value = DateTime.Now;
            txtSubject.Clear();
            cmbTypeOfIncident.SelectedIndex = -1;
            cmbUser.SelectedIndex = -1;
            cmbTypeOfPriority.SelectedIndex = -1;
            dtpDeadline.Value = DateTime.Now;
            txtDescription.Clear();
            btnAdd.Enabled = false;
        }

        private void AddingTicket()
        {
            Ticket ticket = new Ticket(dtpDate.Value = DateTime.Now, txtSubject.Text, (Enums.TypeOfIncident)cmbTypeOfIncident.SelectedIndex,
                    (User)userService.GetUserByEmailTest(user.Email), (Enums.TypeOfPriority)cmbTypeOfPriority.SelectedIndex, dtpDeadline.Value, txtDescription.Text);

            ticketService = new TicketService();
            ticketService.AddTicket(ticket);
            CleanForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ticket == null)
            {
                AddingTicket();
                MessageBox.Show("Your ticket has been added!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            users = userService.GetAllUsers();

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                cmbUser.Items.Add(user.Email);
            }
            else
            {
                foreach (User user in users)
                {
                    cmbUser.Items.Add(user.Email);
                }
            }
            cmbTypeOfIncident.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeOfPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            // assign values to the combobox from the enums
            cmbTypeOfIncident.DataSource = Enum.GetValues(typeof(Enums.TypeOfIncident));
            cmbTypeOfPriority.DataSource = Enum.GetValues(typeof(Enums.TypeOfPriority));
        }

        private void EnableButtonAdd()
        {
            if (txtSubject.Text != "" && txtDescription.Text != "" && cmbUser.SelectedIndex > -1 && cmbTypeOfIncident.SelectedIndex > -1 && cmbTypeOfIncident.SelectedIndex > -1 && dtpDeadline.Value > DateTime.Now)
            {
                btnAdd.Enabled = true;
            }
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }

        private void cmbTypeOfIncident_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }

        private void cmbTypeOfPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            EnableButtonAdd();
        }
    }
}

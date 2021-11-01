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
        private DateTime DateTimeReported;
        public AddTicket(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            userService = new UserService();

            InitializeComponent();
            DateTimeReported = DateTime.Now;
            txtDateReported.Text = DateTimeReported.ToString();
        }

        private void AddingTicket()
        {
            Ticket ticket = new Ticket(DateTimeReported, txtSubject.Text, (Enums.TypeOfIncident)cmbTypeOfIncident.SelectedIndex,
                    (User)userService.GetUserObjectByEmail(cmbUser.Text), (Enums.TypeOfPriority)cmbTypeOfPriority.SelectedIndex, dtpDeadline.Value, txtDescription.Text);

            ticketService = new TicketService();
            ticketService.AddTicket(ticket);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ticket == null)
            {
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

                if (cmbUser.SelectedIndex <= -1)
                {
                    MessageBox.Show("Please fill out the user");
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
        //private void EnableButtonAdd()
        //{
        //    if (txtSubject.Text != "" && txtDescription.Text != "" && cmbUser.SelectedIndex > -1 && cmbTypeOfIncident.SelectedIndex > -1 && cmbTypeOfIncident.SelectedIndex > -1 && dtpDeadline.Value > DateTime.Now)
        //    {
        //        btnAdd.Enabled = true;
        //    }
        //}

        //private void txtSubject_TextChanged(object sender, EventArgs e)
        //{
        //    EnableButtonAdd();
        //}

        //private void cmbTypeOfIncident_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    EnableButtonAdd();
        //}

        //private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    EnableButtonAdd();
        //}

        //private void cmbTypeOfPriority_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    EnableButtonAdd();
        //}

        //private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        //{
        //    EnableButtonAdd();
        //}

        //private void txtDescription_TextChanged(object sender, EventArgs e)
        //{
        //    EnableButtonAdd();
        //}
    }
}

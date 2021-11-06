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

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
                btnManageUser.Hide();
        }

        private void AddingTicket()
        {
            var objid = ((User)cmbUser.SelectedItem).Id;
            Ticket ticket = new Ticket(DateTimeReported, txtSubject.Text, (Enums.TypeOfIncident)cmbTypeOfIncident.SelectedIndex,
                    (User)userService.GetUserObjectById(objid), (Enums.TypeOfPriority)cmbTypeOfPriority.SelectedIndex, dtpDeadline.Value, txtDescription.Text);

            ticketService = new TicketService();
            ticketService.AddTicket(ticket);
            MessageBox.Show("Your ticket has been added!");
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
                    MessageBox.Show("Please fill out the signinUser");
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
                this.Hide();
                TicketOverviewForm tof = new TicketOverviewForm(user);
                tof.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TicketOverviewForm tof = new TicketOverviewForm(user);
            this.Hide();
            tof.ShowDialog();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            lblEmailSignedIn.Text = user.Email;

            users = userService.GetAllUsers();

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                cmbUser.Items.Add(user);
                cmbUser.DisplayMember = "Email";
                cmbUser.ValueMember = "Id";
            }
            else
            {
                cmbUser.DisplayMember = "Email";
                cmbUser.ValueMember = "Id";
                cmbUser.DataSource = users;
            }

            cmbTypeOfIncident.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeOfPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            // assign values to the combobox from the enums
            cmbTypeOfIncident.DataSource = Enum.GetValues(typeof(Enums.TypeOfIncident));
            cmbTypeOfPriority.DataSource = Enum.GetValues(typeof(Enums.TypeOfPriority));
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

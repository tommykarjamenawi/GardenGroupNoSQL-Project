using System;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using System.Collections.Generic;

namespace GardenGroupUI
{
    public partial class DeleteOrUpdateUser : Form
    {
        User user = new User();
        User user1 = new User();
        UserService userService = new UserService();
        UserArchiveService userArchiveService = new UserArchiveService();
        TicketService ticketService = new TicketService();
        public DeleteOrUpdateUser(User user1,User user)
        {
            InitializeComponent();
            this.user = user;
            this.user1 = user1;
            FillForm();
        }

        void FillForm()
        {
            txtFirstName.Text = user1.FirstName;
            txtLastName.Text = user1.LastName;
            txtPhoneNumber.Text = user1.Phone;
            txtEmailAddress.Text = user1.Email;
            cmbLocationBranch.DataSource = Enum.GetValues(typeof(Enums.Branch));
            cmbLocationBranch.Text = user1.branch;
            cmbTypeOfUser.DataSource = Enum.GetValues(typeof(Enums.TypeOfUser));
            cmbTypeOfUser.Text = user1.TypeOfUser;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to Update this user", "Confirmation",
                                                           MessageBoxButtons.YesNo);

            List<Ticket> tickets = ticketService.GetAllTickets();

            this. user.FirstName = txtFirstName.Text;
            this.user.LastName = txtLastName.Text;
            this.user.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            this.user.Email = txtEmailAddress.Text;
            this.user.Phone = txtPhoneNumber.Text;
            this.user.branch = cmbLocationBranch.Text;
            if (dialogResult == DialogResult.Yes)
            {
                userService.UpdateUser(user);
                foreach (Ticket t in tickets)
                {
                    if (user.Id==t.ReportedBy.Id)
                    {
                        t.ReportedBy = user;
                        ticketService.UpdateTicket(t);
                    }

                }


                showManageUser();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to remove this user","!Important",
                                                        MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                userService.RemoveUser(user);
                MessageBox.Show("User succesfully removed");
                showManageUser();
            }
            

           
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to archive this user", "!Important",
                                                      MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //archiveService.AddUser(user);
                userService.RemoveUser(user);
                userArchiveService.AddUser(user);
                MessageBox.Show("User succesfully archived");

                showManageUser();
            }
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            showManageUser();
        }

        private void btnTicketOverview_Click(object sender, EventArgs e)
        {
            TicketOverviewForm ticketOverviewForm = new TicketOverviewForm(user);
            this.Hide();
            ticketOverviewForm.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TicketOverviewStatistics ticketOverviewStatistics = new TicketOverviewStatistics(user);
            this.Hide();
            ticketOverviewStatistics.ShowDialog();
        }

        void showManageUser()
        {
            ManageUser manageUser = new ManageUser(user);
            this.Hide();
            manageUser.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Hide();
            loginScreen.ShowDialog();
        }

       
    }
}

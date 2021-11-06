using System;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using System.Collections.Generic;

namespace GardenGroupUI
{
    public partial class DeleteOrUpdateUser : Form
    {
        private User signinUser;
        private User user ;
        private UserService userService ;
        private UserArchiveService userArchiveService ;
        private TicketService ticketService ;
        public DeleteOrUpdateUser(User user,User signinUser)
        {
            InitializeComponent();
            this.signinUser = signinUser;
            this.user = user;
            userService = new UserService();
            userArchiveService = new UserArchiveService();
            ticketService = new TicketService();
            FillForm();
        }

        void FillForm()
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtPhoneNumber.Text = user.Phone;
            txtEmailAddress.Text = user.Email;
            cmbLocationBranch.DataSource = Enum.GetValues(typeof(Enums.Branch));
            cmbLocationBranch.Text = user.branch;
            cmbTypeOfUser.DataSource = Enum.GetValues(typeof(Enums.TypeOfUser));
            cmbTypeOfUser.Text = user.TypeOfUser;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to Update this user", "Confirmation",
                                                           MessageBoxButtons.YesNo);

            List<Ticket> tickets = ticketService.GetAllTickets();

            this.user.FirstName = txtFirstName.Text;
            this.user.LastName = txtLastName.Text;
            this.user.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            this.user.Email = txtEmailAddress.Text;
            this.user.Phone = txtPhoneNumber.Text;
            this.user.branch = cmbLocationBranch.Text;
            if (txtChangePassword.Text != "")
            {
                HashWithSalt hashWithSalt = new HashWithSalt(txtChangePassword.Text); // creates hashed password with salt
                user.Password = hashWithSalt.hashedPassword;
                user.salt = hashWithSalt.salt;
            }
            
            if (dialogResult == DialogResult.Yes)
            {
                userService.UpdateUser(user);
                foreach (Ticket t in tickets)
                {
                    if (signinUser.Id==t.ReportedBy.Id)
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
                //archiveService.AddUser(signinUser);
                userService.RemoveUser(user);
                userArchiveService.AddUser(user );
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
            TicketOverviewForm ticketOverviewForm = new TicketOverviewForm(signinUser);
            this.Hide();
            ticketOverviewForm.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TicketOverviewStatistics ticketOverviewStatistics = new TicketOverviewStatistics(signinUser);
            this.Hide();
            ticketOverviewStatistics.ShowDialog();
        }

        void showManageUser()
        {
            ManageUser manageUser = new ManageUser(signinUser);
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

using System;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;


namespace GardenGroupUI
{
    public partial class AddUser : Form
    {
        private User user;
        private User signinUser;
        private UserService userService;
        
        public AddUser(User signinUser)
        {
            InitializeComponent();
            InitializeComBox();
            this.signinUser = signinUser;
            userService = new UserService();
            btnAdd.Enabled=false;
            lblEmailSignedIn.Text = signinUser.Email;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text;
            User user = userService.SearchUsers(email);

            if (user==null)
            {
                AddingUser();
                MessageBox.Show("User has been added");
            }
            else
            {
                MessageBox.Show("Email already used");
            }

        }


        private void AddingUser()
        {
            user = new User();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            user.Email = txtEmailAddress.Text;
            user.Phone = txtPhoneNumber.Text;
            user.branch = cmbLocationBranch.Text;
            HashWithSalt hashWithSalt = new HashWithSalt(txtPassword.Text); // creates hashed password with salt
            user.Password = hashWithSalt.hashedPassword;
            user.salt = hashWithSalt.salt;
            userService.AddUser(user);
            CleanForm();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser(signinUser);
            this.Hide();
            manageUser.ShowDialog();
        }

        private void InitializeComBox()
        {
            cmbTypeOfUser.Items.AddRange(Enum.GetNames(typeof(Enums.TypeOfUser)));
            cmbLocationBranch.Items.AddRange(Enum.GetNames(typeof(Enums.Branch)));
        }

        private void CleanForm()
        {
            txtEmailAddress.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            cmbLocationBranch.SelectedIndex = -1;
            cmbTypeOfUser.SelectedIndex = -1;
            btnAdd.Enabled = false;
        }

        private void EnablebuttonAdd()
        {
            if (txtFirstName.TextLength > 0 && txtLastName.TextLength > 0 && txtPhoneNumber.TextLength > 0 && txtEmailAddress.TextLength > 0 && cmbLocationBranch.SelectedIndex >-1 && cmbTypeOfUser.SelectedIndex > -1)
            {
                btnAdd.Enabled = true;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            EnablebuttonAdd();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            EnablebuttonAdd();
        }

        private void cmbTypeOfUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnablebuttonAdd();
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            EnablebuttonAdd();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            EnablebuttonAdd();
        }

        private void cmbLocationBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnablebuttonAdd();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser(signinUser);
            this.Hide();
            manageUser.ShowDialog();

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Hide();
            loginScreen.ShowDialog();
        }
    }
}

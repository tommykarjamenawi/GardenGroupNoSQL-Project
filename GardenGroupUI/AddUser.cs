using System;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;


namespace GardenGroupUI
{
    public partial class AddUser : Form
    {
        User user;
        User signinUser;
        UserService userService = new UserService();
        
        public AddUser(User signinUser)
        {
            InitializeComponent();
            InitializeComBox();
            this.signinUser = signinUser;
            btnAdd.Enabled=false;
            lblEmailSignedIn.Text = signinUser.Email;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string SearchBox = txtEmailAddress.Text;
            User user = userService.SearchUsers(SearchBox);

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
            user.Email = txtEmailAddress.Text + "@Gardengroup.nl";
            user.Phone = txtPhoneNumber.Text;
            user.branch = cmbLocationBranch.Text;
            user.Password = CreatePassword();

            userService = new UserService();
            userService.AddUser(user);
            CleanForm();
        }

        public string CreatePassword()
        {
            int passwordLength = 8;
            string password = "";
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
           // StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < passwordLength--)
            {
                //res.Append(valid[rnd.Next(valid.Length)]);
                password += valid[rnd.Next(valid.Length)];
            }
            return password;
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

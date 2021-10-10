using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupLogic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using System.Management;
using GardenGroupModel;

namespace GardenGroupUI
{
    public partial class LoginScreen : Form
    {
        string email;
        string password;
        UserService userService;
        public LoginScreen()
        {
            InitializeComponent();        
            // Disable ability to resize the login screen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            userService = new UserService();
            // error message hidden on default
            //lblError.Visible = false;
            // Set up MongoDB conventions
            var pack = new ConventionPack
            {
              new EnumRepresentationConvention(BsonType.String)
            };          
            ConventionRegistry.Register("EnumStringConvention", pack, t => true);

            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            foreach (ManagementObject mo in mbsList)
            {
                lblHardwareID.Text = mo["ProcessorId"].ToString();
                break;
            }

            txtEmail.Text = "email";
            txtEmail.ForeColor = Color.DarkGray;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "password";
            txtPassword.ForeColor = Color.DarkGray;
            txtPassword.TabStop = false; // Prevent application to enter the password field on startup
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //lblError.Visible = false;
            email = txtEmail.Text;
            password = txtPassword.Text;

            CredentialsEntered(email, password);
            User user = userService.GetUserByEmail(email, password);
            if (user != null)
            {
                lblError.Text = "correct";
                this.Hide();
                TicketOverviewForm ticketOverviewForm = new TicketOverviewForm(user);
                ticketOverviewForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("please enter correct email or password!");
            }
        }

        public void CredentialsEntered(string user, string key)
        {
            if (!(user.Length >= 1 && key.Length >= 1))
            {
                lblError.Visible = true;
                txtEmail.Text = "";
                txtPassword.Text = "";
                lblError.Text = "username and/or password is incorrect!";
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtEmail.ForeColor == Color.Black)
            {

            }
            else
            {
                txtEmail.ForeColor = Color.Black;
                txtEmail.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "username")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
            if (txtEmail.ForeColor == Color.Black)
            {

            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "username";
                txtEmail.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            if (txtPassword.ForeColor == Color.Black)
            {

            }
            else
            {
                txtPassword.ForeColor = Color.Black;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length >= 1)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
            if (txtPassword.ForeColor == Color.Black)
            {

            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.DarkGray;
            }
        }
    }
}

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

namespace GardenGroupUI
{
    public partial class LoginScreen : Form
    {
        string username;
        string password;
        UserService userService;
        public LoginScreen()
        {
            InitializeComponent();
            userService = new UserService();
            // Disable ability to resize the login screen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            // error message hidden on default
            //lblError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //lblError.Visible = false;
            username = txtUsername.Text;
            password = txtPassword.Text;
            CredentialsEntered(username, password);
            if (userService.CheckUser(username))
            {
                lblError.Text = "correct";
            }
            else
            {
                lblError.Text = "not correct";
            }
        }

        public void CredentialsEntered(string user, string key)
        {
            if (!(user.Length >= 1 && key.Length >= 1))
            {
                lblError.Visible = true;
                txtUsername.Text = "";
                txtPassword.Text = "";
                lblError.Text = "username and/or password is incorrect!";
            }
        }
    }
}

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

namespace GardenGroupUI
{
    public partial class AddUser : Form
    {
        User user;
        UserService UserService;
        public AddUser()
        {
            InitializeComponent();
            InitializeComBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                user = new User();
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
                user.Email = txtEmailAddress.Text;
                user.Phone = txtPhoneNumber.Text;
                user.branch = cmbLocationBranch.Text;


                UserService = new UserService();
                UserService.AddUser(user);
                CleanForm();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            this.Hide();
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
            cmbLocationBranch.Text = "";
            cmbTypeOfUser.Text = "";
        }
    }
}

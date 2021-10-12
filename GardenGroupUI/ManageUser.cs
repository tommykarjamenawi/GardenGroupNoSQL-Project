using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class ManageUser : Form
    {
        private UserService userService = new UserService();

        public ManageUser()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.Show();
                FillForm();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}\n Contact IT department");
            }
        }

        public void FillForm()
        {
            List<User> users = userService.GetAllUsers();

            foreach (User u in users)
            {
                ListViewItem li = new ListViewItem(u.Id.ToString());
                li.SubItems.Add(u.Email.ToString());
                li.SubItems.Add(u.FirstName.ToString());
                li.SubItems.Add(u.LastName.ToString());
                li.Tag = u;
                lstUsers.Items.Add(li);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBox.TextLength == 0)
            {
                FillForm();
            }
        }

        private void Search()
        {
            string SearchBox = txtSearchBox.Text.ToString();
            User user = userService.SearchUsers(SearchBox);
            if (user != null)
            {
                lstUsers.Items.Clear();

                ListViewItem li = new ListViewItem(user.Id.ToString());
                li.SubItems.Add(user.Email.ToString());
                li.SubItems.Add(user.FirstName.ToString());
                li.SubItems.Add(user.LastName.ToString());
                
                lstUsers.Items.Add(li);
            }
            else
            {
                lstUsers.Items.Clear();
                lblsearchcheck.ForeColor = Color.Red;
                lblsearchcheck.Text = "user does not exist";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lstUsers.SelectedIndices.Count>0)
            {
                User user = (User)lstUsers.SelectedItems[0].Tag;
               DeleteOrUpdateUser deleteOrUpdateUser = new DeleteOrUpdateUser(user);
                deleteOrUpdateUser.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            FillForm();
        }
    }
}
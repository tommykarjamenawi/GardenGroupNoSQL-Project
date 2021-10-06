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
    public partial class ManageUser : Form
    {
        UserService userService = new UserService();
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
            List<User> users = userService.GetAllUsers();

            foreach (User u in users)
            {
                ListViewItem li = new ListViewItem(u.Id.ToString());
                li.SubItems.Add(u.Email.ToString());
                li.SubItems.Add(u.FirstName.ToString());
                li.SubItems.Add(u.LastName.ToString());

                lstUsers.Items.Add(li);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            String SearchBox = txtSearchBox.Text.ToString();
            lblsearchcheck.Text = txtSearchBox.Text.ToString();
            List<User> users = userService.SearchUsers(SearchBox);

        }
    }
}

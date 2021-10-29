using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class Archive : Form
    {
        ArchiveService archiveService;
        UserService userService;
        public Archive()
        {
            InitializeComponent();
            archiveService = new ArchiveService();
            userService = new UserService();
            FillForm();


        }

        public void FillForm()
        {
            lstUsers.Items.Clear();
            List<User> userArchives = archiveService.GetAllArchivedUsers();
            foreach (User u in userArchives)
            {
                ListViewItem li = new ListViewItem(u.Id.ToString());
                li.SubItems.Add(u.Email.ToString());
                li.SubItems.Add(u.FirstName.ToString());
                li.SubItems.Add(u.LastName.ToString());
                li.Tag = u;
                lstUsers.Items.Add(li);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            this.Hide();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
          
            if (lstUsers.SelectedIndices.Count > 0)
            {
                User user = (User)lstUsers.SelectedItems[0].Tag;
                archiveService.RemoveUser(user);
                userService.AddUser(user);
                FillForm();
            }
        }
    }
}

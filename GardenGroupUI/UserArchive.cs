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
    public partial class UserArchive : Form
    {
        UserArchiveService archiveService;
        UserService userService;
        private User signinUser;

        public UserArchive(User signinUser)
        {
            InitializeComponent();
            archiveService = new UserArchiveService();
            userService = new UserService();
            this.signinUser = signinUser;
            FillForm();
            lblEmailSignedIn.Text = signinUser.Email;


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

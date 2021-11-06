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
        private UserService userService ;
        private TicketService ticketService ;
        private User signinUser;

        public ManageUser(User signinUser)
        {
            InitializeComponent();
            userService = new UserService();
            ticketService = new TicketService();
            this.signinUser = signinUser;

            // this will make the size of the searchbox
            this.txtSearchBox.AutoSize = false;
            this.txtSearchBox.Size = new System.Drawing.Size(261, 25);
            lblEmailSignedIn.Text = signinUser.Email;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(signinUser);
            this.Hide();
            addUser.ShowDialog();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            try
            { 
                FillForm();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}\n Contact IT department");
            }
        }

        public void FillForm()
        {
            lstUsers.Items.Clear();
            List<User> users = userService.GetAllUsers();
            List<Ticket> tickets;
            foreach (User u in users)
            {
                ListViewItem li = new ListViewItem(u.Id.ToString());
                li.SubItems.Add(u.Email.ToString());
                li.SubItems.Add(u.FirstName.ToString());
                li.SubItems.Add(u.LastName.ToString());
                tickets = ticketService.GetAllTicketsForUser(u);
                li.SubItems.Add(tickets.Count.ToString());
                li.Tag = u;
                lstUsers.Items.Add(li);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBox.Text) == false)
            {
                Search();
            }
            else
            {

                FillForm();
            }
        }


        // this methode will check a signinUser by the giving starting letters
        private void Search()
        {
            string SearchBox = txtSearchBox.Text.ToString();
            List<User> users = userService.GetAllUsers();
            lstUsers.Items.Clear();
            foreach (User user in users)
            {
                if (user.Email.StartsWith(SearchBox))
                {

                    ListViewItem li = new ListViewItem(user.Id.ToString());
                    li.SubItems.Add(user.Email.ToString());
                    li.SubItems.Add(user.FirstName.ToString());
                    li.SubItems.Add(user.LastName.ToString());
                    li.Tag = user;
                    lstUsers.Items.Add(li);
                }
            }
        }

      

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lstUsers.SelectedIndices.Count>0)
            {
                User user1 = (User)lstUsers.SelectedItems[0].Tag;
                DeleteOrUpdateUser deleteOrUpdateUser = new DeleteOrUpdateUser(user1, signinUser);
                this.Hide();
                deleteOrUpdateUser.ShowDialog();
               
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            txtSearchBox.Clear();
            FillForm();
        }

       

        private void btnOpenArchive_Click(object sender, EventArgs e)
        {
            UserArchive archive = new UserArchive(signinUser);
            this.Hide();
            archive.ShowDialog();
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
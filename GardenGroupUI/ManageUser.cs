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
        TicketService ticketService = new TicketService();
        UserArchiveService archiveService = new UserArchiveService();

        public ManageUser()
        {
            InitializeComponent();
            this.txtSearchBox.AutoSize = false;
            this.txtSearchBox.Size = new System.Drawing.Size(261, 25);

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

                    lstUsers.Items.Add(li);
                }
            }
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
            
            txtSearchBox.Clear();
            FillForm();
        }

       

        private void btnOpenArchive_Click(object sender, EventArgs e)
        {
            UserArchive archive = new UserArchive();
            archive.Show();
            this.Hide();
        }
    }
}
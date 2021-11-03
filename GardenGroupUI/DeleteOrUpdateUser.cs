using System;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;
using System.Collections.Generic;

namespace GardenGroupUI
{
    public partial class DeleteOrUpdateUser : Form
    {
        User user = new User();
        UserService userService = new UserService();
        UserArchiveService userArchiveService = new UserArchiveService();
        TicketService ticketService = new TicketService();
        public DeleteOrUpdateUser(User user)
        {
            InitializeComponent();
            this.user = user;
            FillForm();
        }

        void FillForm()
        {
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtPhoneNumber.Text = user.Phone;
            txtEmailAddress.Text = user.Email;
            cmbLocationBranch.DataSource = Enum.GetValues(typeof(Enums.Branch));
            cmbLocationBranch.Text = user.branch;
            cmbTypeOfUser.DataSource = Enum.GetValues(typeof(Enums.TypeOfUser));
            cmbTypeOfUser.Text = user.TypeOfUser;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to Update this user", "Confirmation",
                                                           MessageBoxButtons.YesNo);

            List<Ticket> tickets = ticketService.GetAllTickets();

            this. user.FirstName = txtFirstName.Text;
            this.user.LastName = txtLastName.Text;
            this.user.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            this.user.Email = txtEmailAddress.Text;
            this.user.Phone = txtPhoneNumber.Text;
            this.user.branch = cmbLocationBranch.Text;
            if (dialogResult == DialogResult.Yes)
            {
                userService.UpdateUser(user);
                foreach (Ticket t in tickets)
                {
                    if (user.Id==t.ReportedBy.Id)
                    {
                        t.ReportedBy = user;
                        ticketService.UpdateTicket(t);
                    }

                }
                

                this.Hide();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to remove this user","!Important",
                                                        MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                userService.RemoveUser(user);
                MessageBox.Show("User succesfully removed");
                this.Close();
            }
            

           
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure\n you want to archive this user", "!Important",
                                                      MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //archiveService.AddUser(user);
                userService.RemoveUser(user);
                userArchiveService.AddUser(user);
                MessageBox.Show("User succesfully archived");
                
                this.Close();
            }
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void btnTicketOverview_Click(object sender, EventArgs e)
        {
            TicketOverviewForm ticketOverviewForm = new TicketOverviewForm(user);
            this.Hide();
            ticketOverviewForm.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TicketOverviewStatistics ticketOverviewStatistics = new TicketOverviewStatistics(user);
            this.Hide();
            ticketOverviewStatistics.ShowDialog();
        }
    }
}

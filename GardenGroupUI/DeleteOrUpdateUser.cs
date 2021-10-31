using System;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;

namespace GardenGroupUI
{
    public partial class DeleteOrUpdateUser : Form
    {
        User user = new User();
        UserService userService = new UserService();
        //ArchiveService archiveService = new ArchiveService();
        public DeleteOrUpdateUser(User user )
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

            this. user.FirstName = txtFirstName.Text;
            this.user.LastName = txtLastName.Text;
            this.user.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            this.user.Email = txtEmailAddress.Text;
            this.user.Phone = txtPhoneNumber.Text;
            this.user.branch = cmbLocationBranch.Text;
            if (dialogResult == DialogResult.Yes)
            {
                userService.UpdateUser(user);

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
                MessageBox.Show("User succesfully archived");
                this.Close();
            }
        }
    }
}

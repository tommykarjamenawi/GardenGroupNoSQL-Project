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
            cmbLocationBranch.Text = user.branch;
            cmbTypeOfUser.SelectedItem = user.TypeOfUser;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1.Id = user.Id;
            user1.FirstName = txtFirstName.Text;
            user1.LastName = txtLastName.Text;
           // user1.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            user1.Email = txtEmailAddress.Text;
            user1.Phone = txtPhoneNumber.Text;
          //  user1.branch = cmbLocationBranch.Text;


            userService.UpdateUser(user1);
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
    }
}

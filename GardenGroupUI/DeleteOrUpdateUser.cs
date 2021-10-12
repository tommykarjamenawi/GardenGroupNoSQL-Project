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
          
          
           this. user.FirstName = txtFirstName.Text;
            this.user.LastName = txtLastName.Text;
            // user1.TypeOfUser = cmbTypeOfUser.SelectedItem.ToString();
            this.user.Email = txtEmailAddress.Text;
            this.user.Phone = txtPhoneNumber.Text;
          //  user1.branch = cmbLocationBranch.Text;


            userService.UpdateUser(user);
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

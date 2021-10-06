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
    public partial class AddUser : Form
    {
        User user;
        UserService UserService;
        public AddUser()
        {
            InitializeComponent();
            AddEnumToComBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            user = new User();
            user.FirstName = txtFirstName.Text.ToString();
            user.LastName = txtLastName.Text;
            string userType = cmbTypeOfUser.SelectedItem.ToString();

            if (userType == "End User")
            {
                user.TypeOfUser = Enums.TypeOfUser.EndUser;
            }
            else
            {
                user.TypeOfUser = Enums.TypeOfUser.ServiceDeskEmployee;
            }

            user.Email = txtEmailAddress.Text;
            user.Phone = txtPhoneNumber.Text;
            string Branch = cmbLocationBranch.SelectedItem.ToString();

            if (Branch == "Haarlem")
            {
                user.branch = Enums.Branch.Haarlem;
            }
            else if (Branch == "Amsterdam")
            {
                user.branch = Enums.Branch.Amsterdam;
            }
            else if (Branch == "Headquarters")
            {
                user.branch = Enums.Branch.Headquarters;
            }
            else if (Branch == "Knuppeldam")
            {
                user.branch = Enums.Branch.Knuppeldam;
            }
            UserService = new UserService();
            UserService.AddUser(user);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
            this.Hide();
        }

        void AddEnumToComBox()
        {
            cmbTypeOfUser.Items.Add(Enums.TypeOfUser.EndUser);
            cmbTypeOfUser.Items.Add(Enums.TypeOfUser.ServiceDeskEmployee);
            cmbLocationBranch.Items.Add(Enums.Branch.Amsterdam);
            cmbLocationBranch.Items.Add(Enums.Branch.Haarlem);
            cmbLocationBranch.Items.Add(Enums.Branch.Headquarters);
            cmbLocationBranch.Items.Add(Enums.Branch.Knuppeldam);
        }
    }
}

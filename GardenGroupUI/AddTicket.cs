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
using MongoDB.Bson;

namespace GardenGroupUI
{
    public partial class AddTicket : Form
    {
        private Ticket ticket;
        private TicketService ticketService;
        private UserService userService;
        private List<User> users;
        private User user;
        public AddTicket(User user)
        {
            this.user = user;
            
            ticketService = new TicketService();
            userService = new UserService();

            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Ticket ticket = new Ticket(dtpDate.Value, txtSubject.Text, (Enums.TypeOfIncident)cmbTypeOfIncident.SelectedIndex,
                    (User)userService.GetUserByEmailTest(user.Email), (Enums.TypeOfPriority)cmbTypeOfPriority.SelectedIndex, dtpDeadline.Value, txtDescription.Text);
                
                //ticket.ReportedBy = cmbUser.Text;
                //ticket.Subject = txtSubject.Text;
                //ticket.Description = txtDescription.Text;
                //ticket.ReportedDate = dtpDate.Value;
                //ticket.Deadline = dtpDeadline.Value;
                //ticket.TypeOfIncident = cmbTypeOfIncident.SelectedItem.ToString();
                //ticket.TypeOfPriority = cmbTypeOfPriority.SelectedItem.ToString();

                ticketService.AddTicket(ticket);
                MessageBox.Show("Your ticket has been added!");

                TicketOverviewForm tof = new TicketOverviewForm(user);
                this.Hide();
                tof.ShowDialog();



            } catch(NullReferenceException exp)
            {
                MessageBox.Show($"{exp}" + "Please fill out all the fields");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            users = userService.GetAllUsers();

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                cmbUser.Items.Add(user.Email);
            }
            else
            {
                foreach (User user in users)
                {
                    cmbUser.Items.Add(user.Email);
                }
            }

            cmbTypeOfIncident.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeOfPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            // assign values to the combobox from the enums
            cmbTypeOfIncident.DataSource = Enum.GetValues(typeof(Enums.TypeOfIncident));
            cmbTypeOfPriority.DataSource = Enum.GetValues(typeof(Enums.TypeOfPriority));
        }
    }
}

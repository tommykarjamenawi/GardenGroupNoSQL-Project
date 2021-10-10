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
        public AddTicket()
        {
            ticketService = new TicketService();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket(dtpDate.Value, txtSubject.Text, (Enums.TypeOfIncident)cmbTypeOfIncident.SelectedIndex,
                    cmbUser.SelectedItem.ToString(), (Enums.TypeOfPriority)cmbTypeOfPriority.SelectedIndex, dtpDeadline.Value, txtDescription.Text);

                //ticket.ReportedBy = cmbUser.Text;
                //ticket.Subject = txtSubject.Text;
                //ticket.Description = txtDescription.Text;
                //ticket.ReportedDate = dtpDate.Value;
                //ticket.Deadline = dtpDeadline.Value;
                //ticket.TypeOfIncident = cmbTypeOfIncident.SelectedItem.ToString();
                //ticket.TypeOfPriority = cmbTypeOfPriority.SelectedItem.ToString();

                ticketService.AddTicket(ticket);
                MessageBox.Show("Your ticket has been added!");
                this.Close();
            } catch(Exception exp)
            {
                MessageBox.Show("A problem has occured while attempting to add your ticket! " + exp.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            users = userService.GetAllUsers();

            cmbTypeOfIncident.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeOfPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            // assign values to the combobox from the enums
            cmbTypeOfIncident.DataSource = Enum.GetValues(typeof(Enums.TypeOfIncident));
            cmbTypeOfPriority.DataSource = Enum.GetValues(typeof(Enums.TypeOfPriority));

            foreach(User user in users)
            {
                cmbUser.Items.Add(ReportedByFullName(user.Id));
            }
        }

        private string ReportedByFullName(ObjectId id)
        {
            string reportedFullName = "";

            foreach (User user in users)
            {
                if (id.Equals(user.Id))
                {
                    reportedFullName = user.FirstName + " " + user.LastName;
                    break;
                }
            }
            return reportedFullName;
        }
    }
}

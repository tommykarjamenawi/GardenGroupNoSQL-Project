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
    public partial class TicketOverviewStatistics : Form
    {
        private TicketService ticketService;
        private List<Ticket> allTickets;
        private List<Ticket> userTickets;
        private User user;
        public TicketOverviewStatistics(User user)
        {
            this.user = user;
            ticketService = new TicketService();
            InitializeComponent();
        }

        private void btnShowTickets_Click(object sender, EventArgs e)
        {
            TicketOverviewForm tof = new TicketOverviewForm(user);
            this.Hide();
            tof.ShowDialog();
        }

        private void TicketOverviewStatistics_Load(object sender, EventArgs e)
        {
            lblEmailSignedIn.Text = user.Email;

            allTickets = ticketService.GetAllTickets();
            userTickets = ticketService.GetAllTicketsForUser(user);

            int nrOfUnsolvedTickets = 0;
            int nrOfSolvedTickets = 0;
            int nrOfTicketsPastDeadline = 0;
            int nrOfTicketsBeforeDeadline = 0;

            if (user.TypeOfUser == Enums.TypeOfUser.EndUser.ToString())
            {
                foreach(Ticket ticket in userTickets)
                {
                    if (ticket.IsSolved == false)
                        nrOfUnsolvedTickets++;
                    else
                        nrOfSolvedTickets++;
                    if (ticket.Deadline <= DateTime.Now)
                        nrOfTicketsPastDeadline++;
                    if (ticket.Deadline > DateTime.Now)
                        nrOfTicketsBeforeDeadline++;
                    lblTotalTickets.Text = userTickets.Count.ToString();
                }
            }
            else
            {
                foreach (Ticket ticket in allTickets)
                {
                    if (ticket.IsSolved == false)
                        nrOfUnsolvedTickets++;
                    else
                        nrOfSolvedTickets++;
                    if (ticket.Deadline <= DateTime.Now)
                        nrOfTicketsPastDeadline++;
                    if (ticket.Deadline > DateTime.Now)
                        nrOfTicketsBeforeDeadline++;
                    lblTotalTickets.Text = allTickets.Count.ToString();
                }
            }

            lblUnsolvedTickets.Text = nrOfUnsolvedTickets.ToString();
            lblPastDeadline.Text = nrOfTicketsPastDeadline.ToString();

            UnsolvedTicketsChart(nrOfUnsolvedTickets, nrOfSolvedTickets);
            IncidentsPastDeadlineChart(nrOfTicketsPastDeadline, nrOfTicketsBeforeDeadline);
        }

        private void UnsolvedTicketsChart(int nrOfUnsolvedTickets, int nrOfSolvedTickets)
        {
            chartUnresolvedTickets.Series["Unresolved incidents"].Points.AddXY("Unsolved tickets", nrOfUnsolvedTickets);
            chartUnresolvedTickets.Series["Unresolved incidents"].Points.AddXY("Solved tickets", nrOfSolvedTickets);
            chartUnresolvedTickets.Series["Unresolved incidents"]["DoughnutRadius"] = "50";
            chartUnresolvedTickets.Series[0].Points[0].Color = Color.Yellow;
            chartUnresolvedTickets.Series[0].Points[1].Color = Color.LightGray;
            chartUnresolvedTickets.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartUnresolvedTickets.Series["Unresolved incidents"].IsValueShownAsLabel = true;
        }

        private void IncidentsPastDeadlineChart(int nrOfTicketsPastDeadline, int nrOfTicketsBeforeDeadline)
        {
            chartIncidentsPastDeadline.Series["Past deadline"].Points.AddXY("Past deadline", nrOfTicketsPastDeadline);
            chartIncidentsPastDeadline.Series["Past deadline"].Points.AddXY("Before deadline", nrOfTicketsBeforeDeadline);
            chartIncidentsPastDeadline.Series["Past deadline"]["DoughnutRadius"] = "50";
            chartIncidentsPastDeadline.Series[0].Points[0].Color = Color.Red;
            chartIncidentsPastDeadline.Series[0].Points[1].Color = Color.LightGray;
            chartIncidentsPastDeadline.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartIncidentsPastDeadline.Series["Past deadline"].IsValueShownAsLabel = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            this.Hide();
            ls.ShowDialog();
        }
    }
}

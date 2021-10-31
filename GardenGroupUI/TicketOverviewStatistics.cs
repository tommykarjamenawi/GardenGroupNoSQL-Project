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
        private List<Ticket> tickets;
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
            tickets = ticketService.GetAllTickets();

            int nrOfUnsolvedTickets = 0;
            int nrOfSolvedTickets = 0;
            int nrOfTicketsPastDeadline = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.IsSolved == false)
                    nrOfUnsolvedTickets++;
                else
                    nrOfSolvedTickets++;
                if (ticket.Deadline <= DateTime.Now)
                    nrOfTicketsPastDeadline++;
            }

            lblUnsolvedTickets.Text = nrOfUnsolvedTickets.ToString();
            lblTotalTickets.Text = tickets.Count.ToString();
            lblPastDeadline.Text = nrOfTicketsPastDeadline.ToString();

            chartUnresolvedTickets.Titles.Add("Unresolved incidents");
            chartUnresolvedTickets.Series["Unresolved incidents"].Points.AddXY("Unsolved", nrOfUnsolvedTickets);
            chartUnresolvedTickets.Series["Unresolved incidents"].Points.AddXY("Solved", nrOfSolvedTickets);
            chartUnresolvedTickets.Series["Unresolved incidents"].IsValueShownAsLabel = true;

            chartIncidentsPastDeadline.Titles.Add("Incidents past deadline");
            chartIncidentsPastDeadline.Series["Past deadline"].Points.AddXY("Past deadline", nrOfTicketsPastDeadline);
            chartIncidentsPastDeadline.Series["Past deadline"].IsValueShownAsLabel = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gelre_airport
{
    public partial class CheckInForm : Form
    {
        GelreAirport Airport = null;
        public CheckInForm(int checkInCounterNumber, GelreAirport airport)
        {
            
            InitializeComponent();
            Airport = airport;
        }

        private void btnFindPassenger_Click(object sender, EventArgs e)
        {
            string Name = txtPassengerName.Text;
            int FlightNumber = Convert.ToInt32(txtFlightNumber.Text);
            string Destination = txtDestination.Text;
            string Airline = txtAirline.Text;
            DateTime Departure = Convert.ToDateTime(textBox1.Text);
            //Departure.Date.AddHours(23).AddMinutes(37);
            string formattedDate = Departure.ToString("yyyy-MM-dd HH:mm:ss.fff");
            

            foreach (var passenger in Airport.getPassengersByParameters(Name, FlightNumber, Destination, Airline, formattedDate))
            {
                lbPassengers.Items.Add(passenger);
            }
            
        }
    }
}

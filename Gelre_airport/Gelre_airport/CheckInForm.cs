using Gelre_airport.Classes;
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
        Passenger selectedPassenger = null;
        public CheckInForm(int checkInCounterNumber, GelreAirport airport)
        {
            
            InitializeComponent();
            Airport = airport;
        }

        private void btnFindPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                lbPassengers.Items.Clear();
                string Name = txtPassengerName.Text;
                int FlightNumber = Convert.ToInt32(txtFlightNumber.Text);
                string Destination = txtDestination.Text;
                string Airline = txtAirline.Text;
                var Departure = new DateTime(dtpDeparture.Value.Year, dtpDeparture.Value.Month, dtpDeparture.Value.Day, Convert.ToInt32(nudHour.Value), Convert.ToInt32(nudMinute.Value), 0);
                string formattedDate = Departure.ToString("yyyy-MM-dd HH:mm:ss.fff");

                foreach (var passenger in Airport.getPassengersByParameters(Name, FlightNumber, Destination, Airline, formattedDate))
                {
                    lbPassengers.Items.Add(passenger);
                }

                txtBaggageFlightNumber.Text = txtFlightNumber.Text;
                txtBaggageFlightNumber.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vul alle velden correct in");
            }
            
            

            
            
        }

        private void lbPassengers_SelectedValueChanged(object sender, EventArgs e)
        {
            lbPassengerBaggage.Items.Clear();
            selectedPassenger = lbPassengers.SelectedItem as Passenger;
            if (selectedPassenger != null)
            {
                foreach (var pieceOfLuggage in Airport.getLuggageByPassengerNumber(selectedPassenger.passengerNumber))
                {
                    lbPassengerBaggage.Items.Add(pieceOfLuggage);
                }
                
            }
            else
            {
                MessageBox.Show("Selecteer een passagier");
            }
        }

        private void btnDeleteLuggage_Click(object sender, EventArgs e)
        {
            var selectedPieceOfLuggage = lbPassengerBaggage.SelectedItem as Luggage;
            if (selectedPieceOfLuggage != null)
            {
                Airport.deleteLuggageByTrackingNumber(selectedPieceOfLuggage.trackingNumber);
                if (this.selectedPassenger != null)
                {
                    lbPassengerBaggage.Items.Clear();
                    foreach (var pieceOfLuggage in Airport.getLuggageByPassengerNumber(selectedPassenger.passengerNumber))
                    {
                        lbPassengerBaggage.Items.Add(pieceOfLuggage);
                    }
                }
            }
        }

        private void btnAddLuggage_Click(object sender, EventArgs e)
        {
            if (selectedPassenger != null)
            {
                try
                {
                    Airport.addLuggageToPassenger(selectedPassenger.passengerNumber, Convert.ToInt32(txtFlightNumber.Text), Convert.ToInt32(txtWeight.Text));
                    if (this.selectedPassenger != null)
                    {
                        lbPassengerBaggage.Items.Clear();
                        foreach (var pieceOfLuggage in Airport.getLuggageByPassengerNumber(selectedPassenger.passengerNumber))
                        {
                            lbPassengerBaggage.Items.Add(pieceOfLuggage);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vul alle velden correct in");
                }
                
            }
        }
    }
}

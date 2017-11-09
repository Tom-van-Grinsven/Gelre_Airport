using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;

namespace Gelre_airport.Database.Interfaces
{
    public interface IPassengerContext
    {
        List<Passenger> GetPassengersByParameters(string Name, int FlightNumber, string Destination, string Airline, String Departure);

        Boolean checkInPassenger(int passengerNumber, int flightNumber, string seatNumber);
    }
}

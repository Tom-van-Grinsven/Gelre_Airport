using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;
using Gelre_airport.Database.Interfaces;

namespace Gelre_airport.Repositories
{
    public class PassengerRepository
    {
        private IPassengerContext _context;

        public PassengerRepository(IPassengerContext context)
        {
            this._context = context;
        }

        public bool checkInPassenger(int passengerNumber, int flightNumber, int counterNumber, DateTime checkInTime, int seatNumber)
        {
            return _context.checkInPassenger(passengerNumber, flightNumber, counterNumber, checkInTime, seatNumber);
        }

        public List<Passenger> GetPassengersByParameters(string Name, int FlightNumber, string Destination, string Airline, String Departure)
        {
            return _context.GetPassengersByParameters(Name, FlightNumber, Destination, Airline, Departure);
        }


    }
}

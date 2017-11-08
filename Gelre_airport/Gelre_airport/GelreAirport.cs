using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Repositories;
using Gelre_airport.Database.MSSQLContext;
using Gelre_airport.Classes;

namespace Gelre_airport
{
    public class GelreAirport
    {
        public CheckInCounterRepository counterRepo = new CheckInCounterRepository(new CheckInCounterMSSQLContext());
        public PassengerRepository passengerRepo = new PassengerRepository(new PassengerMSSQLContext());
        public LuggageRepository luggageRepo = new LuggageRepository(new LuggageMSSQLContext());
        public FlightRepository flightRepo = new FlightRepository(new FlightMSSQLContext());

        public List<CheckInCounter> counters { get; set; }

        public GelreAirport()
        {
            counters = counterRepo.getAllCheckInCounters();           
        }

        public List<Passenger> getPassengersByParameters(string Name, int FlightNumber, string Destination, string Airline, String Departure)
        {
            return passengerRepo.GetPassengersByParameters(Name, FlightNumber, Destination, Airline, Departure);
        }

        public List<Luggage> getLuggageByPassengerNumber(int passengerNumber, int flightNumber)
        {
            return luggageRepo.getLuggageByPassengerNumber(passengerNumber, flightNumber);
        }

        public List<Flight> getFlightByFlightNumber(int flightNumber)
        {
            return flightRepo.getByFlightNumber(flightNumber);
        }

        public Boolean checkInPassenger(int passengerNumber, int flightNumber, int counterNumber, DateTime checkInTime, int seatNumber)
        {
            return passengerRepo.checkInPassenger(passengerNumber, flightNumber, counterNumber, checkInTime, seatNumber);
        }

        public Boolean deleteLuggageByTrackingNumber(int trackingNumber)
        {
            return luggageRepo.deleteLuggageByTrackingNumber(trackingNumber);
        }

        public Boolean addLuggageToPassenger(int passengerNumber, int flightNumber, int weight)
        {
            return luggageRepo.addLuggageToPassenger(passengerNumber, flightNumber, weight);
        }
    }
}

using Gelre_airport.Database.Interfaces;
using Gelre_airport.Database.MSSQLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;

namespace Gelre_airport.Repositories
{
    public class LuggageRepository
    {
        private ILuggageContext _context;

        public LuggageRepository(LuggageMSSQLContext context)
        {
            this._context = context;
        }

        public List<Luggage> getLuggageByPassengerNumber(int passengerNumber, int flightNumber)
        {
            return _context.getLuggageByPassengerNumber(passengerNumber, flightNumber);
        }

        public bool addLuggageToPassenger(int passengerNumber, int flightNumber, int weight)
        {
            return _context.addLuggageToPassenger(passengerNumber, flightNumber, weight);
        }

        public bool deleteLuggageByTrackingNumber(int trackingNumber)
        {
            return _context.deleteLuggageByTrackingNumber(trackingNumber);
        }
    }
}

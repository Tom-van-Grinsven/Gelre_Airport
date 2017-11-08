using Gelre_airport.Classes;
using Gelre_airport.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelre_airport.Repositories
{
    public class FlightRepository
    {
        private IFlightContext _context;

        public FlightRepository(IFlightContext context)
        {
            this._context = context;
        }

        public List<Flight> getByFlightNumber(int flightNumber)
        {
            return _context.getByFlightNumber(flightNumber);
        }
    }
}

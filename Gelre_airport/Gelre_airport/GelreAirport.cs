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
    class GelreAirport
    {
        public CheckInCounterRepository counterRepo = new CheckInCounterRepository(new CheckInCounterMSSQLContext());

        public List<CheckInCounter> counters { get; set; }

        public GelreAirport()
        {
            counters = counterRepo.getAllCheckInCounters();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;
using Gelre_airport.Database.Interfaces;

namespace Gelre_airport.Repositories
{
    class CheckInCounterRepository
    {
        private ICheckInCounterContext _context;

        public CheckInCounterRepository(ICheckInCounterContext context)
        {
            this._context = context;
        }

        public List<CheckInCounter> getAllCheckInCounters()
        {
            return _context.getAllCheckInCounters();
        }
    }
}

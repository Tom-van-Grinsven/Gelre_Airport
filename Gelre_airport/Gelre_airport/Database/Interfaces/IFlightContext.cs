using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;

namespace Gelre_airport.Database.Interfaces
{
    public interface IFlightContext
    {
        List<Flight> getByFlightNumber(int flightNumber);
    }
}

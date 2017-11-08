using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelre_airport.Classes
{
    public class Flight
    {
        public int flightNumber { get; private set; }
        public string gateCode { get; private set; }
        public string airlineCode { get; private set; }
        public string airportCode { get; private set; }
        public string airplaneType { get; private set; }
        public int maxPassengers { get; private set; }
        public int maxLoad { get; private set; }
        public int maxLoadPerPassenger { get; private set; }
        public DateTime departure { get; private set; }
        public DateTime arrival { get; private set; }


        public Flight(int flightNumber, string gateCode,
            string airlineCode, string airportCode, 
            string airplaneType, int maxPassengers,
            int maxLoad, int maxLoadPerPassenger,
            DateTime departure, DateTime arrival)
        {
            this.flightNumber = flightNumber;
            this.gateCode = gateCode;
            this.airlineCode = airlineCode;
            this.airportCode = airportCode;
            this.airplaneType = airplaneType;
            this.maxPassengers = maxPassengers;
            this.maxLoad = maxLoad;
            this.maxLoadPerPassenger = maxLoadPerPassenger;
            this.departure = departure;
            this.arrival = arrival;
        }

        public override string ToString()
        {
            return String.Format(" Gate code: {0}, Max gewicht/passagier {1}, Vertrektijd: {2}, Aankomsttijd: {3} ", 
                gateCode, maxLoadPerPassenger, departure, arrival);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelre_airport.Classes
{
    public class Luggage
    {
        public int trackingNumber { get; set; }
        public int passengerNumber { get; set; }
        public int flightNumber { get; set; }
        public int weight { get; set; }

        public Luggage(int trackingNumber, int weight)
        {
            this.trackingNumber = trackingNumber;
            this.weight = weight;
        }

        public Luggage()
        {

        }



        public override string ToString()
        {
            return String.Format("Volgnummer: {0}, Gewicht: {1}", trackingNumber, weight);
        }
    }
}

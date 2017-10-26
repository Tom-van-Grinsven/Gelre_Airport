using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelre_airport.Classes
{
    public class CheckInCounter
    {
        public int CheckInCounterNumber { get; private set; }

        public CheckInCounter(int CheckInCounterNumber)
        {
            this.CheckInCounterNumber = CheckInCounterNumber;
        }

        public override string ToString()
        {
            return String.Format("Balienummer: {0}", this.CheckInCounterNumber);
        }
    }
}

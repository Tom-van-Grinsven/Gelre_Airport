using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelre_airport.Classes
{
    public class Passenger
    {
        public int passengerNumber { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public DateTime dateOfBirth { get; private set; }


        public Passenger(int passengerNumber, string Name, string Gender, DateTime dateOfBirth)
        {
            this.passengerNumber = passengerNumber;
            this.Name = Name;
            this.Gender = Gender;
            this.dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return String.Format("Naam: {0}, Geslacht: {1}, Geboortedatum: {2}", Name, Gender, dateOfBirth.ToShortDateString());
        }
    }
}

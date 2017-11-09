using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;
using Gelre_airport.Database.Interfaces;
using System.Data.SqlClient;

namespace Gelre_airport.Database.MSSQLContext
{
    public class PassengerMSSQLContext : IPassengerContext
    {

        public List<Passenger> GetPassengersByParameters(string Name, int FlightNumber, string Destination, string Airline, String Departure)
        {
            List<Passenger> passengers = new List<Passenger>();
            string query = "select p.passagiernummer, p.naam, p.geslacht, p.geboortedatum from passagier p " +
                            "join passagiervoorvlucht pvv on p.passagiernummer = pvv.passagiernummer " +
                            "join vlucht v on pvv.vluchtnummer = v.vluchtnummer " +
                            "join luchthaven l on v.luchthavencode = l.luchthavencode " +
                            "where p.naam = @Name and " +
                            "pvv.vluchtnummer = @FlightNumber and " +
                            "l.land = @Destination and " +
                            "v.maatschappijcode = @Airline and " +
                            "v.vertrekTijdstip = @Departure";

            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@FlightNumber", FlightNumber);
                        command.Parameters.AddWithValue("@Destination", Destination);
                        command.Parameters.AddWithValue("@Airline", Airline);
                        command.Parameters.AddWithValue("@Departure", Departure);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                passengers.Add(new Passenger(
                                    Convert.ToInt32(reader["passagiernummer"]),
                                    Convert.ToString(reader["naam"]),
                                    Convert.ToString(reader["geslacht"]),
                                    Convert.ToDateTime(reader["geboortedatum"])
                                    ));
                            }
                            return passengers;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return null;
        }

        public bool checkInPassenger(int passengerNumber, int flightNumber, string seatNumber)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand("spStoelVoorPassagier", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@passagiernummer", passengerNumber);
                        command.Parameters.AddWithValue("@vluchtnummer", flightNumber);
                        command.Parameters.AddWithValue("@stoel", seatNumber);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return false;
        }

    }
}

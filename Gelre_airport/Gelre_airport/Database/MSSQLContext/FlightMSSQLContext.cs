using Gelre_airport.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gelre_airport.Classes;
using System.Data.SqlClient;

namespace Gelre_airport.Database.MSSQLContext
{
    public class FlightMSSQLContext : IFlightContext
    {
        public List<Flight> getByFlightNumber(int flightNumber)
        {
            List<Flight> flights = new List<Flight>();
            string query = "select * from vlucht where vluchtnummer = @flightNumber";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@flightNumber", flightNumber);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                flights.Add(new Flight(
                                    Convert.ToInt32(reader["vluchtnummer"]),
                                    Convert.ToString(reader["gatecode"]),
                                    Convert.ToString(reader["maatschappijcode"]),
                                    Convert.ToString(reader["luchthavencode"]),
                                    Convert.ToString(reader["vliegtuigtype"]),
                                    Convert.ToInt32(reader["max_aantal_psgrs"]),
                                    Convert.ToInt32(reader["max_totaalgewicht"]),
                                    Convert.ToInt32(reader["max_ppgewicht"]),
                                    Convert.ToDateTime(reader["vertrektijdstip"]),
                                    Convert.ToDateTime(reader["aankomsttijdstip"])
                                    ));
                            }
                            return flights;
                        }
                    }
                }
            }
            catch (SqlException)
            {

            }
            return null;
        }
    }
}

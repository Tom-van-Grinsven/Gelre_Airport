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
    public class LuggageMSSQLContext : ILuggageContext
    {
        public List<Luggage> getLuggageByPassengerNumber(int passengerNumber, int flightNumber)
        {
            List<Luggage> luggage = new List<Luggage>();

            string query = "select o.volgnummer, o.gewicht from Object o " +
                "join Passagier p on p.passagiernummer = o.passagiernummer " +
                "where o.passagiernummer = @passengerNumber" +
                " and o.vluchtnummer = @flightNumber";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@passengerNumber", passengerNumber);
                        command.Parameters.AddWithValue("@flightNumber", flightNumber);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                luggage.Add(new Luggage(
                                    Convert.ToInt32(reader["volgnummer"]),
                                    Convert.ToInt32(reader["gewicht"])
                                    ));
                            }
                            return luggage;
                        }
                    }
                }
            }
            catch (SqlException)
            {

            }
            return null;
        }

        public bool addLuggageToPassenger(int passengerNumber, int flightNumber, int weight)
        {
            string query = "INSERT Object(passagiernummer, vluchtnummer, gewicht) VALUES(@passengerNumber, @flightNumber, @weight)";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@passengerNumber", passengerNumber);
                        command.Parameters.AddWithValue("@flightNumber", flightNumber);
                        command.Parameters.AddWithValue("@weight", weight);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return false;

        }
    
        public bool deleteLuggageByTrackingNumber(int trackingNumber)
        {
            string query = "delete from object where volgnummer = @trackingNumber";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@trackingNumber", trackingNumber);
                        command.ExecuteNonQuery();
                        return true;                       
                    }
                }
            }
            catch (SqlException)
            {

            }
            return false;

        }
    }
}

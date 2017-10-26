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
    class CheckInCounterMSSQLContext : ICheckInCounterContext

    {
        public List<CheckInCounter> getAllCheckInCounters()
        {
            List<CheckInCounter> checkInCounters = new List<CheckInCounter>();
            string query = "select * from balie";
            try
            {
                using (SqlConnection connection = DatabaseConnection.Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                checkInCounters.Add(new CheckInCounter(
                                    Convert.ToInt32(reader["balienummer"])
                                    ));
                            }
                            return checkInCounters;
                        }
                    }
                }
            }
            catch(SqlException)
            {

            }
            return null;
        }
    }
}

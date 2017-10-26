using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gelre_airport.Database
{
    public class DatabaseConnection
    {
        private const string connectionString =
           "Server=DESKTOP-OEVOS92\\MSSQLSERVER01;Database=gelre_airport;Trusted_Connection=True;";

        public static SqlConnection Connection
        {
            get
            {
                var connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    throw new Exception("No connection could be made.");
                }
                return connection;
            }
        }
    }
}


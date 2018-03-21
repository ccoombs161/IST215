using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=IT215_CUSTOMER;Integrated Security=True";
            // Build and execute the SQL
            string cmdStr = "INSERT INTO Customers (CustomerID,CompanyName) "
                              + "VALUES ('1004','Xerox Corp.')";

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, conn);

                int retVal = cmd.ExecuteNonQuery();
                Console.WriteLine("Insert returned {0}", retVal);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Failed: {0}", ex.ToString());
            }
            finally
            {
                // Must always close the connection when done
                if (conn != null)
                    conn.Close();
            }

        }
    }
}

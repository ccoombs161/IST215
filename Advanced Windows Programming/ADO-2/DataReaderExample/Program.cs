using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// http://www.akadia.com/services/dotnet_data_reader.html

namespace TestingCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = @"data source=localhost;initial catalog=NorthWind;integrated security=sspi";
            // string commandString = @"SELECT COUNT(*) FROM Products";

            SqlDataReader rdr = null;
            SqlConnection con = null;
            SqlCommand cmd = null;

                        
            try
             {
                 // Open connection to the database
                 
                 con = new SqlConnection(ConnectionString);
                 con.Open();

                 // Set up a command with the given query and associate
                 // this with the current connection.
                 string CommandText = "SELECT FirstName, LastName" +
                                      "  FROM Employees" +
                                      " WHERE (LastName LIKE @Find)";
                 cmd = new SqlCommand(CommandText);
                 cmd.Connection = con;

                 // Add LastName to the above defined paramter @Find
                 cmd.Parameters.Add(
                     new SqlParameter(
                     "@Find",                           // The name of the parameter to map
                     System.Data.SqlDbType.NVarChar,    // SqlDbType values
                     20,                                // The width of the parameter
                     "LastName"));                      // The name of the source column

                 // Fill the parameter with the value retrieved
                // from the text field
                 cmd.Parameters["@Find"].Value = "B%";

                 // Execute the query
                 rdr = cmd.ExecuteReader();

                 // Fill the list box with the values retrieved
                 //lbFound.Items.Clear();
                 while(rdr.Read())
                 {
                     Console.WriteLine(rdr["FirstName"].ToString() +
                     " " + rdr["LastName"].ToString());
                 }
             }
             catch(Exception ex)
             {
                 // Print error message
                 Console.WriteLine("Exception: " + ex.Message);
             }
             finally
             {
                 // Close data reader object and database connection
                 if (rdr != null)
                     rdr.Close();

                 if (con.State == ConnectionState.Open)
                     con.Close();
             }
            

        }
    }
}

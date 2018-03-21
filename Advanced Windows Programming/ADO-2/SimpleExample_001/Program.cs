using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        //string connectionString =
        //    "Data Source=(local);Initial Catalog=Northwind;"
        //    + "Integrated Security=true";
        string connectionString="Data Source=.;Database=BlueYonder.Server.Lab06;User Id=RAMBLER\\MohammadSaleem;Password=Billa29Jaro;Integrated Security=true"; //providerName="System.Data.SqlClient"

        //connectionString="Data Source=.;Database=BlueYonder.Server.Lab06;User Id=RAMBLER\MohammadSaleem;Password=TurkLyn4;Integrated Security=true" providerName="System.Data.SqlClient"

        // Provide the query string with a parameter placeholder. 
        string queryString = "SELECT TOP 1000 [FlightId] ,[FlightNumber], [FrequentFlyerMiles], [Source_LocationId], [Destination_LocationId] FROM dbo.Flights";            
            
            //"SELECT ProductID, UnitPrice, ProductName from dbo.products "
            //    + "WHERE UnitPrice > @pricePoint "
            //    + "ORDER BY UnitPrice DESC;";

        // Specify the parameter value. 
        int paramValue = 5;

        // Create and open the connection in a using block. This 
        // ensures that all resources will be closed and disposed 
        // when the code exits. 
        using (SqlConnection connection =
            new SqlConnection(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            //command.Parameters.AddWithValue("@pricePoint", paramValue);

            // Open the connection in a try/catch block.  
            // Create and execute the DataReader, writing the result 
            // set to the console window. 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                              
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + " ");
                    }
                    Console.WriteLine();
                    //Console.WriteLine("\t{0}\t{1}\t{2}",
                    //    reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
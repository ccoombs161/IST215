using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add a reference to System.Configuration

namespace DataSet3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter();
            
            // sCustomerOrder must be in App.Config file
            var sConn = ConfigurationManager.ConnectionStrings["sCustomerOrder"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(sConn))
            {
                connection.Open();
                SqlCommand comm1 = new SqlCommand(@"SELECT TOP 10 * FROM Customers;", connection);
                SqlCommand comm2 = new SqlCommand(@"SELECT TOP 10 * FROM CUSTOMERS C, [Orders] O WHERE C.CustomerID = O.CustomerID;", connection);

                // create the following tables in the dataset
                ds.Tables.Add("Customers");
                ds.Tables.Add("Orders");

                // Turn off constraints in the dataset. 
                // For example: You can use this by pass unique constraints.
                // ds.EnforceConstraints = false;

                // Populate the tables.
                adapt.SelectCommand = comm1;
                adapt.Fill(ds.Tables["Customers"]);
                adapt.SelectCommand = comm2;
                adapt.Fill(ds.Tables["Orders"]);

                // Turn off constraints in the dataset.
                // ds.EnforceConstraints = true;

                //retrieve first table data
                Console.WriteLine("\nCustomers table. Row Count: {0}, Column Count: {1}",
                    ds.Tables["Customers"].Rows.Count, ds.Tables["Customers"].Rows[0].ItemArray.Length);
                Console.WriteLine();
                for (int j = 0; j <= ds.Tables["Customers"].Rows.Count - 1; j++)
                {
                    foreach (var item in ds.Tables["Customers"].Rows[j].ItemArray)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nCustomers table, short version");
                for (int i = 0; i <= ds.Tables["Customers"].Rows.Count - 1; i++)
                {
                    Console.WriteLine(ds.Tables["Customers"].Rows[i].ItemArray[0] + " -- " + ds.Tables["Customers"].Rows[i].ItemArray[1]);
                }

                Console.WriteLine("\nOrders, Row Count: {0}, Column Count: {1}",
                    ds.Tables["Orders"].Rows.Count, ds.Tables["Orders"].Rows[0].ItemArray.Length);
                Console.WriteLine();
                for (int j = 0; j < ds.Tables["Orders"].Rows.Count; j++)
                {
                    Console.Write("{0}) ", j);
                    foreach (var cell in ds.Tables["Orders"].Rows[j].ItemArray)
                    {
                        Console.Write(cell + " ");
                    }
                    Console.WriteLine();
                }

                comm1.Dispose();
            }
            adapt.Dispose();
        }
    }
}

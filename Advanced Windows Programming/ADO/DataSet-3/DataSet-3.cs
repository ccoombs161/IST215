using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Data.DataSet);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.1
 * https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset.acceptchanges?view=netframework-4.7.1#System_Data_DataSet_AcceptChanges
*/
namespace DataSet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ConnectionString = "Data Source=localhost;Initial Catalog=NorthWind;Integrated Security=True";
            //string cmd = @"SELECT * FROM CUSTOMERS";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //DataSet dsCustomer = new DataSet();
            //SqlDataAdapter daCustomer = new SqlDataAdapter(cmd, conn);

            string connectionString = GetConnectionString();
            DataSet ds = ConnectToData(connectionString);
            DataTable tbl = ds.Tables["Suppliers"];

            Console.WriteLine();
            
            //walk all the rows
            StringBuilder sb;
            foreach (DataRow row in tbl.Rows)
            {
                //walk each field of the row
                sb = new StringBuilder();
                foreach (var column in row.ItemArray)
                {
                    sb = sb.Append(column.ToString().Trim() + " ");
                }
                Console.WriteLine(sb.ToString());   // print the whole row.                
            }
            //DataRow myRow = tbl.NewRow();
            //myRow["SupplierID"] = 30;
            //myRow["CompanyName"] = "NortWest Trade Company";

            //// Add the row.
            //tbl.Rows.Add(myRow);

            //// Calling AcceptChanges on the DataSet causes AcceptChanges to be
            //// called on all subordinate objects.
            //ds.AcceptChanges();
        }
        private static DataSet ConnectToData(string connectionString)
        {
            DataSet dataSet = null;
            
            //Create a SqlConnection to the Northwind database.
            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                //Create a SqlDataAdapter for the Suppliers table.
                SqlDataAdapter adapter = new SqlDataAdapter();

                // A table mapping names the DataTable.
                adapter.TableMappings.Add("Table", "Suppliers");

                // Open the connection.
                connection.Open();
                Console.WriteLine("The SqlConnection is open.");

                // Create a SqlCommand to retrieve Suppliers data.
                SqlCommand command = new SqlCommand(
                    "SELECT SupplierID, CompanyName FROM dbo.Suppliers;",
                    connection);
                command.CommandType = CommandType.Text;

                // Set the SqlDataAdapter's SelectCommand.
                adapter.SelectCommand = command;

                // Fill the DataSet.
                dataSet = new DataSet("Suppliers");
                adapter.Fill(dataSet);

                // Create a second Adapter and Command to get
                // the Products table, a child table of Suppliers. 
                SqlDataAdapter productsAdapter = new SqlDataAdapter();
                productsAdapter.TableMappings.Add("Table", "Products");

                SqlCommand productsCommand = new SqlCommand(
                    "SELECT ProductID, SupplierID FROM dbo.Products;",
                    connection);
                productsAdapter.SelectCommand = productsCommand;

                // Fill the DataSet.
                productsAdapter.Fill(dataSet);

                // Close the connection.
                connection.Close();
                Console.WriteLine("The SqlConnection is closed.");

                // Create a DataRelation to link the two tables
                // based on the SupplierID.
                DataColumn parentColumn =
                    dataSet.Tables["Suppliers"].Columns["SupplierID"];
                DataColumn childColumn =
                    dataSet.Tables["Products"].Columns["SupplierID"];
                DataRelation relation =
                    new System.Data.DataRelation("SuppliersProducts",
                    parentColumn, childColumn);
                dataSet.Relations.Add(relation);
                Console.WriteLine(
                    "The {0} DataRelation has been created.",
                    relation.RelationName);
            } // SqlConnection;

            return dataSet;
        } // end ConnectToData

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=(local);Initial Catalog=Northwind;"
                + "Integrated Security=SSPI";
        }

    }
}

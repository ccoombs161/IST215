using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://msdn.microsoft.com/en-us/library/System.Data.Common.DataAdapter_properties(v=vs.110).aspx
 */

namespace SQLAdapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=IT215_CUSTOMER;Integrated Security=True";
            //string cmd = @"SELECT * FROM CUSTOMER";
            string str1 = "10003";
            string str2 = "Boston Electronics";
            
            string cmd = @"INSERT INTO CUSTOMERS VALUES ( " + str1 + ",'" + str2 + "')" ;
            SqlConnection conn = new SqlConnection(ConnectionString);
            DataSet dsCustomer = new DataSet();
            SqlDataAdapter daCustomer = CreateSqlDataAdapter(conn);
            // SqlDataAdapter daCustomer = new SqlDataAdapter(cmd, conn);
            
            //dsCutomer.Tables["Customers"].Rows[0]["CustomerID"] = "10000";
            //dsCutomer.Tables["Customers"].Rows[0]["CompanyName"] = "Boston Electronics";
            
            //Post the data modification to the database.
            //daCustomer.Update(dsCutomer, "Customers");


            daCustomer.Fill(dsCustomer);
            DataTable tblCustomer = dsCustomer.Tables["Customers"];  // get the first table.


            Console.WriteLine("Customer Name updated successfully");


            //walk all the rows
            foreach (DataRow row in tblCustomer.Rows)
            {
                //walk each field of the row
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }
            conn.Close();

        }
        public static SqlDataAdapter CreateSqlDataAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Determines the action to take when existing DataSet schema does not match incoming data.
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            // Create the commands.
            adapter.SelectCommand = new SqlCommand(
                "SELECT CustomerID, CompanyName FROM CUSTOMERS WHERE CustomerID = -1", connection);
            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO Customers (CustomerID, CompanyName) " +
                "VALUES (@CustomerID, @CompanyName)", connection);
            adapter.UpdateCommand = new SqlCommand(
                "UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName " +
                "WHERE CustomerID = @oldCustomerID", connection);

            adapter.DeleteCommand = new SqlCommand(
                "DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);

            // Create the parameters.
            adapter.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Char, 5, "CustomerID");
            adapter.InsertCommand.Parameters.Add("@CompanyName", SqlDbType.VarChar, 40, "CompanyName");

            adapter.UpdateCommand.Parameters.Add("@CustomerID", SqlDbType.Char, 5, "CustomerID");
            adapter.UpdateCommand.Parameters.Add("@CompanyName", SqlDbType.VarChar, 40, "CompanyName");

            adapter.UpdateCommand.Parameters.Add("@oldCustomerID", SqlDbType.Char, 5, 
                "CustomerID").SourceVersion = DataRowVersion.Original;

            adapter.DeleteCommand.Parameters.Add("@CustomerID", SqlDbType.Char, 5, 
                "CustomerID").SourceVersion = DataRowVersion.Original;

            return adapter;
        }

    }
}

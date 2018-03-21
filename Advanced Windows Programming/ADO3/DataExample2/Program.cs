using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection = @"data source=localhost; Initial catalog=Northwind; integrated security=SSPI";
            // string oConn = @"data source=localhost; Initial catalog=CUSTOMER_ORDER; Provider=SQLOLEDB; integrated security=SSPI";
            // Assumes that customerConnection is a valid SqlConnection object.  
            // Assumes that orderConnection is a valid OleDbConnection object.  
            SqlDataAdapter custAdapter = new SqlDataAdapter(
              "SELECT * FROM dbo.Customers", connection);
            // OleDbDataAdapter ordAdapter = new OleDbDataAdapter( "SELECT * FROM Orders", oConn);
            SqlDataAdapter ordAdapter = new SqlDataAdapter("SELECT * FROM dbo.[Orders]", connection);

            DataSet customerOrder = new DataSet();

            custAdapter.Fill(customerOrder, "Customers");
            ordAdapter.Fill(customerOrder, "[Orders]");

            DataRelation relation = customerOrder.Relations.Add("CustOrder",
              customerOrder.Tables["Customers"].Columns["CustomerID"],
              customerOrder.Tables["[Orders]"].Columns["CustomerID"]);

            foreach (DataRow pRow in customerOrder.Tables["Customers"].Rows)
            {
                Console.WriteLine(pRow["CustomerID"]);
                foreach (DataRow cRow in pRow.GetChildRows(relation))
                    Console.WriteLine("\t" + cRow["OrderID"]);
            }

        }
    }
}

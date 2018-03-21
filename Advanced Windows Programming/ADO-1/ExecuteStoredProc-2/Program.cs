using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteStoredProc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string strConnect = "Data Source=localhost;Initial Catalog=CUSTOMER_ORDER_V2;Integrated Security=True";
            // sCustomerOrder must be in App.Config file
            var sConn = ConfigurationManager.ConnectionStrings["sConn"].ConnectionString;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            // SqlDataAdapter adpOrders = new SqlDataAdapter();

            SqlConnection conn = null;
            conn = new SqlConnection(sConn);

            using (SqlConnection connection = new SqlConnection(sConn))
            {
                connection.Open();
                SqlCommand comm1 = new SqlCommand(@"SELECT TOP 10 * FROM Customers;", connection);
                SqlCommand comm2 = new SqlCommand(@"SELECT TOP 10 * FROM CUSTOMERS C, [Orders] O WHERE C.CustomerID = O.CustomerID;", connection);

                // create the following tables in the dataset
                ds.Tables.Add("Customers");
                ds.Tables.Add("Orders");

                //DataColumn customerColumn, orderColumn;
                //customerColumn = ds.Tables["Customers"].Columns["ID"];
                //orderColumn = ds.Tables["Orders"].Columns["CustomerID"];
                //DataRelation dr = new DataRelation("CustomerOrders", customerColumn, orderColumn);
                //ds.Relations.Add(dr);
                                              
                // Turn off constraints in the dataset. 
                // For example: You can use this by pass unique constraints.
                // ds.EnforceConstraints = false;

                SqlCommand SelectCmd = new SqlCommand(@"SELECT C.CustomerID, O.OrderNum, C.CustomerName, O.ProductName, O.ProductType, O.Quantity, O.UnitPrice, O.TotalPrice FROM CUSTOMER AS C JOIN[ORDER] AS O ON C.CustomerID = O.CustomerID;", conn);
                adapter.SelectCommand = SelectCmd;
                decimal UnitPrice = 23.00M;
                int Quantity = 77;

                SqlCommand command = new SqlCommand(@"UPDATE Orders SET Quantity = @Quantity, UnitPrice = @UnitPrice" + 
                    @"WHERE ProductType = 'Book'", conn);
                command.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = UnitPrice;
                command.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity;
                adapter.UpdateCommand = command;

                SqlParameter parameter = command.Parameters.Add("@oldOrderID", SqlDbType.NChar, 5, "OrderID");
                parameter.SourceVersion = DataRowVersion.Original;
            }
        }

        /*
                private static void AdapterUpdate(string connectionString, int orderNum, int quantity )
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter dataAdpater = new SqlDataAdapter(
                        @"SELECT C.CustomerID, O.OrderNum, C.CustomerName, O.ProductName, O.ProductType, O.Quantity, O.UnitPrice, O.TotalPrice FROM CUSTOMER AS C JOIN[ORDER] AS O ON C.CustomerID = O.CustomerID;",
                        connection);

                        dataAdpater.UpdateCommand = new SqlCommand( @"UPDATE [ORDER] SET Quantity = @Quantity " +
                        "WHERE OrderNum = @OrderNum", connection);

                        dataAdpater.UpdateCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;

                        SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add("@OrderNum", SqlDbType.Int);
                        parameter.SourceColumn = "OrderNum";
                        parameter.SourceVersion = DataRowVersion.Original;

                        DataTable dt = new DataTable();
                        dataAdpater.Fill(dt);

                        DataRow dataRow = dt.Rows[5];
                        dataRow["Quantity"] = quantity;
                        dataAdpater.Update(dt);
                        dataRow.AcceptChanges();

                        Console.WriteLine("Rows after update.");
                        foreach (DataRow row in dt.Rows)
                        {
                            {
                                Console.WriteLine("CustID:{0}, OrderNum:{1}, Quantity:{2}", 
                                    row[0], row[1], row[5]);
                            }
                        }
                    }
                }
        */
    }
}

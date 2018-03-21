using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

/*
 https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(System.Data.SqlClient.SqlDataReader.Read);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5);k(DevLang-csharp)&rd=true
 SQLDataReader Class provides a way of reading a forward-only stream of 
 rows from a SQL Server database.
 The default position of the SqlDataReader is before the first record.
 Therefore, you must call Read to begin accessing any data. 
 Only one SqlDataReader per associated SqlConnection may be open at a time,
 and any attempt to open another will fail until the first one is closed.
 Similarly, while the SqlDataReader is being used, the associated SqlConnection
 is busy serving it until you call Close.
*/


namespace DataReader_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sConnectionString = "Data Source=localhost;Initial Catalog=CUSTOMER_ORDER;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sConnectionString);
            //SqlCommand cmd = new SqlCommand(@"SELECT * FROM CUSTOMER", conn);
            //SqlCommand cmd = new SqlCommand(@"SELECT OrderNum, ProductNumber, ORDER.CustomerID AS [O-CustID] CustomerName, City, State, ZIP FROM CUSTOMER JOIN ORDER ON Customer.CustomerID = Order.CustomerID", conn);
            //SqlCommand cmd = new SqlCommand(@"SELECT OrderNum, CustomerName, City FROM CUSTOMER INNER JOIN ORDER ON Customer.CustomerID = Order.CustomerID", conn);
            SqlCommand cmd = new SqlCommand(@"SELECT OrderNum, CustomerName, City FROM CUSTOMER INNER JOIN [ORDER] ON Customer.CustomerID = [ORDER].CustomerID WHERE Customer.CustomerID = 2", conn);
            //@"SELECT OrderNum, CustomerName, City FROM CUSTOMER INNER JOIN [ORDER] ON 
            // Customer.CustomerID = [ORDER].CustomerID WHERE Customer.CustomerID = 2", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // read a row, one at a time.
            StringBuilder sb;
            while (reader.Read())
            {
                sb = new StringBuilder();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    sb = sb.Append((reader.GetValue(i).ToString()).Trim() + " ");
                    // Console.WriteLine(reader.GetValue(i).ToString());
                }
                Console.WriteLine(sb.ToString());
                //Console.WriteLine();
                
            }
            Console.WriteLine("Second attempt...");
            Console.ReadKey();
            conn.Close();

            cmd = new SqlCommand(@"SELECT OrderNum, CustomerName, City FROM CUSTOMER INNER JOIN [ORDER] ON Customer.CustomerID = [ORDER].CustomerID WHERE Customer.CustomerID = 2", conn);
            conn.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow((IDataRecord)reader);
            }

            conn.Close();
            reader.Close();
        }
        private static void ReadSingleRow(IDataRecord reader)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                sb = sb.Append((reader.GetValue(i).ToString()).Trim() + " ");
            }
            Console.WriteLine(sb.ToString());
        }

    }
}

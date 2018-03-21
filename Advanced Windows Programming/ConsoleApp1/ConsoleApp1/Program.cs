using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
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

            SqlCommand cmd = new SqlCommand(@"SELECT OrderNum, CustomerName, CITY FROM CUSTOMER INNER JOIN [ORDER] ON Customer.CustomerID = [ORDER].CustomerID WHERE Customer.CustomerID = 2", conn);


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
            //Console.ReadKey();
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


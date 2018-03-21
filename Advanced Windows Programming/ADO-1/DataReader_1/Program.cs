using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sConnectionString =
                "Data Source=.;Initial Catalog=CUSTOMER_ORDER;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sConnectionString);
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM CUSTOMER", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // read a row, one at a time.
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write("{0,15 }", reader.GetValue(i).ToString().Trim());
                } 
                Console.WriteLine();
                
            }

            conn.Close();

        }
    }
}

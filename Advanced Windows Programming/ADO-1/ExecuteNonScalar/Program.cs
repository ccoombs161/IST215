using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * http://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C
 * https://msdn.microsoft.com/en-us/library/vstudio/bb399375(v=vs.100).aspx
 */

namespace ExecuteNonScalar
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=CUSTOMER_ORDER;Integrated Security=True";
            string sCmd = @"SELECT COUNT(*) FROM CUSTOMER";
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sCmd, conn);
            conn.Open();

            int result = (int)cmd.ExecuteScalar();
            Console.WriteLine("Result = {0}", result);
            conn.Close();
        }
    }
}

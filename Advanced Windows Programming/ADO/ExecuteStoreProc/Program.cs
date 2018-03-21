using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteStoreProc
{
    class Program
    {
        static void Main(string[] args)
        {
			// Build a connection string to connect to the ADONetSamples SQL Server database
            string strConnect = "Data Source=localhost;Initial Catalog=IT215_CUSTOMER;Integrated Security=True";
			SqlConnection conn = null;
			try
			{
				// Open the connection
				conn = new SqlConnection(strConnect);
				conn.Open();

				DoubleSelect(conn);
			}
			catch(SqlException ex)
			{
				Console.WriteLine("Failed: {0}",ex.ToString());
			}
			finally
			{
				// Must always close the connection when done
				if(conn != null)
					conn.Close();
			}
		}  // end of Main

		/// <summary>Demonstrates reading multiple result sets</summary>
		/// <param name="conn">An SQL database connection</param>
   		public static void DoubleSelect(SqlConnection conn)
		{
            string strSQL = "spExecSEL";
			SqlCommand comm = new SqlCommand(strSQL,conn);
			comm.CommandType = CommandType.StoredProcedure;

			SqlDataReader reader = comm.ExecuteReader();

			do
			{
				int iCount = reader.FieldCount;
				while(reader.Read())
				{
					for(int i = 0;i < iCount;i++)
					{
						if(i > 0) Console.Write(", ");
						Console.Write(reader.GetValue(i).ToString().Trim());
					}
					Console.WriteLine("");
				}
				Console.WriteLine("-----");
			} while (reader.NextResult());

			reader.Close();
		}


    }
}

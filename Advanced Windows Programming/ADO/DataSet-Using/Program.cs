using System;
using System.Collections.Generic;
using System.Data;              // for dataset
using System.Data.SqlClient;    // for connection
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Integrated Security's value can be true, false, yes, no, or sspi
 * When Integrated Security=False, UserID and Password are specified in the connection.
 * When Integrated Security=True, the current Windows account credentials are used for authentication. if UserID and Password are provided, they are ignored.
 * When Integrated Security=sspi, if UserId and Password are not provided, the current Windows account credentials are used for authentication.
 * When Integrated Security=sspi, if UserId and Password are provided, they are used for authentication.
*/


namespace DataSet_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string sConnectionString = "Data Source=localhost;Initial Catalog=CUSTOMER_ORDER;Integrated Security=True";
            string sCmd = @"SELECT * FROM CUSTOMER";
            SqlConnection conn = new SqlConnection(sConnectionString);
            DataSet dsCutomer = new DataSet();
            SqlDataAdapter daCustomer = new SqlDataAdapter(sCmd, conn);   //4 overloads: 1) def, 2) cmd,  3) cmdStr, conn, cmdStr, conStr

            /* Fill the dataSet. In here we did not provide a name to the table
             * Therefore you have to access table with an index
             */
            // daCustomer.Fill(dsCutomer);
            // DataTable tblCustomer = dsCutomer.Tables[0];  // get the first table.
            
            daCustomer.Fill(dsCutomer, "Customer");
            DataTable tblCustomer = dsCutomer.Tables["CUSTOMER"]; 

            //walk all the rows
            StringBuilder sb;
            foreach (DataRow row in tblCustomer.Rows)
            {
                //walk each field of the row
                sb = new StringBuilder();
                foreach (var column in row.ItemArray)
                {
                    sb = sb.Append(column.ToString().Trim() + " ");
                }
                Console.WriteLine(sb.ToString());   // print the whole row.                
            }
            conn.Close();
        }
    }
}
// dsCutomer.Tables[0].Columns["CustomerName"].Caption - Gives you name of the column
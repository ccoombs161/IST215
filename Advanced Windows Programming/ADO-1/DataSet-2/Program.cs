using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using SqlCommandBuilder. It creates InsertCommand, UpdateCommand and DeleteCommand on the fly.

namespace DataSet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=IT215_CUSTOMER;Integrated Security=True";
            string cmd = @"SELECT * FROM CUSTOMERS";
            SqlConnection conn = new SqlConnection(ConnectionString);
            DataSet dsCustomer = new DataSet();
            SqlDataAdapter daCustomer = new SqlDataAdapter(cmd, conn);   //4 overloads, 1) def, 2) cmd,  3) cmdStr, conn, cmdStr, conStr

            // Create a wrapper around DataAdapter to support generation 
            // of dynamic update/insert/delete commands
            SqlCommandBuilder bld = new SqlCommandBuilder(daCustomer);
            
            // Fill the DataSet
            daCustomer.Fill(dsCustomer);     // closes the connection with DB
            
            //Get the table out of DataSet
            DataTable tblCustomer = dsCustomer.Tables[0];  // get the first table.
            //DataTable tblCustomer = dsCustomer.Tables["dbo.CUSTOMER"];  //NOT WORKING, not sure why???

            DataTable dtSchema = new DataTable("CUSTOMERS");
            
            // The SchemaType usually should be set to Mapped, because any established table and column mappings are used.
            daCustomer.FillSchema(dtSchema, SchemaType.Mapped);
            Console.WriteLine("Number of Columns: " + dtSchema.Columns.Count);
            for (int i = 0; i < dtSchema.Columns.Count; i++)
            {
                Console.WriteLine("{0} - Type: {1},  Name: {2}", i, dtSchema.Columns[i].GetType().ToString(), dtSchema.Columns[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine();

            //Setup the primary key
            DataColumn[] colArr = new DataColumn[1];
            colArr[0] = tblCustomer.Columns[0];
            tblCustomer.PrimaryKey = colArr;

            //Insert a row
            object[] rowvals = new object[2];
            rowvals[0] = "10001";    // Guid.NewGuid();
            rowvals[1] = "IBM Corp";
            DataRow insertedRow = tblCustomer.Rows.Add(rowvals);


            rowvals[0] = "10021";    // Guid.NewGuid();
            rowvals[1] = "Apple Corp";
            insertedRow = tblCustomer.Rows.Add(rowvals);

            rowvals[0] = "1002";    // Guid.NewGuid();
            rowvals[1] = "Microsoft Corp";
            insertedRow = tblCustomer.Rows.Add(rowvals);
            daCustomer.Update(dsCustomer);    //force update, opens the connection
            DisplayTable(tblCustomer);      // Display the content of the table
            
            
            tblCustomer.Rows[2].Delete();
            daCustomer.Update(dsCustomer);    //force update, opens the connection
            Console.WriteLine("\nDeleted row index 2");

            // tblCustomer.GetChanges();
            // Updating row 1
            tblCustomer.Rows[0].BeginEdit();
            tblCustomer.Rows[0][1] = "The IBM Corporation";

            Console.WriteLine("\nAfter updating row index 1");
            DisplayTable(tblCustomer);      // Display the content of the table

            conn.Close();
        } // end Main

        static void DisplayTable (DataTable dt)
        {
            //walk all the rows
            foreach (DataRow row in dt.Rows)
            {
                //walk each field of the row
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString().Trim() + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

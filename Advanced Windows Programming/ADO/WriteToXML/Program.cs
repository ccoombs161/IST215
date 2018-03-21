using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=CUSTOMER_ORDER;Integrated Security=True";
            string cmd = @"SELECT * FROM CUSTOMER";
            SqlConnection conn = new SqlConnection(ConnectionString);
            DataSet dsCustomer = new DataSet();
            SqlDataAdapter daCustomer = new SqlDataAdapter(cmd, conn);   //4 overloads, 1) def, 2) cmd,  3) cmdStr, conn, cmdStr, conStr

            daCustomer.FillSchema(dsCustomer, SchemaType.Source, "Customer");
            daCustomer.Fill(dsCustomer, "Customer");

            /*
             * If you only use Fill, you can only load the basic metadata that is required to describe the 
             * column names and data types. The Fill method does not load primary key information. 
             * To change this default behavior, you can set the MissingSchemaAction property of the DataAdapter object
             * to MissingSchemaAction.AddWithKey, which loads the primary key metadata along 
             * with the default information.
             * 
             */
            daCustomer.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daCustomer.Fill(dsCustomer, "Customer");
            dsCustomer.WriteXmlSchema("Customer.xsd");        //write schema to xml file.

        }
    }
}

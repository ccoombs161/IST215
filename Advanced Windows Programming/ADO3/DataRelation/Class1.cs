using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace LearningCSharp {
	class SuppliersProducts {
		static void Main(string[] args) {
			DataSet myDataSet = new DataSet();

			// Products Table
			string connectionString = @"data source=localhost; Initial catalog=Northwind; integrated security=SSPI";
			//string connectionString = @"data source=F110-153230\SQLSERVER2012; Initial catalog=Northwind; integrated security=SSPI";
			string commandString = @"SELECT * FROM Suppliers";
			SqlDataAdapter dataAdapter = new SqlDataAdapter( commandString, connectionString );

			// Suppliers Table
			//connectionString = @"data source=localhost; Initial catalog=Northwind; integrated security=SSPI; User Id=sa; Password=BadDog99";
			commandString = @"SELECT * FROM Products";
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter( commandString, connectionString );
            
			dataAdapter.Fill( myDataSet, "Suppliers" );
			dataAdapter2.Fill( myDataSet, "Products" );

            //int tableCount = myDataSet.Tables.Count;
            Console.WriteLine($"Number of tables: {myDataSet.Tables.Count}.\n");

            DataRelation dr = myDataSet.Relations.Add( "ProductSuppliers",
						myDataSet.Tables["Suppliers"].Columns["SupplierID"],
						myDataSet.Tables["Products"].Columns["SupplierID"]
					);

			foreach (DataRow pRow in myDataSet.Tables["Suppliers"].Rows)
            {
				Console.WriteLine(pRow["CompanyName"]);
				foreach (DataRow cRow in pRow.GetChildRows(dr))
                {
					Console.WriteLine("\t" + cRow["ProductName"]);
				}
			}

			// Console.WriteLine("Press ENTER to quit...");
			// Console.ReadKey();

            DataSet dsCustomer = GetCustomerData(connectionString);

            foreach (DataRow cRow in dsCustomer.Tables["Customers"].Rows)
            {
                foreach (var item in cRow.ItemArray)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                // Console.WriteLine($"{cRow[0]} {cRow[1]}");
            }
        }

        public static DataSet GetCustomerData(string connectionString)
        {
            DataSet dataSet = new DataSet("dsCustomer");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT CustomerID, CompanyName, ContactName, City, Country FROM dbo.Customers", connection);

                DataTableMapping mapping = adapter.TableMappings.Add("Table", "Customers");
                mapping.ColumnMappings.Add("CompanyName", "Name");
                mapping.ColumnMappings.Add("ContactName", "Contact");

                connection.Open();

                adapter.FillSchema(dataSet, SchemaType.Mapped);
                adapter.Fill(dataSet);

                return dataSet;
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace LearningCSharp {
	class SampleSqlADO {
		static void Main(string[] args) {
			string connectionString = @"data source=localhost; Initial catalog=Northwind; integrated security=SSPI";
			string commandString = @"SELECT * FROM Customers";
			SqlDataAdapter dataAdapter = new SqlDataAdapter( commandString, connectionString );

			DataSet myDataSet = new DataSet();
			dataAdapter.Fill( myDataSet, "Customers" );

			DataTable myTable = myDataSet.Tables["Customers"];

			int numberRows = myTable.Rows.Count;
			Console.WriteLine("Rows: {0} ", numberRows);

			DataColumn c = myTable.Columns[0];
			Console.WriteLine("Column one: {0}", c.ColumnName );

			Console.WriteLine("Press ENTER to quit...");
			Console.ReadLine();

			
		}
	}
}

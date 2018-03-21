using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;	// included to get the temp path

namespace LearningCSharp {
    class DataSetXMLExample {
        static void Main(string[] args) {
			string tempfile = Path.GetTempFileName();

            //string connectionString = @"data source=localhost; Initial catalog=Northwind; integrated security=SSPI";
            string connectionString = @"data source=localhost; Initial catalog=Northwind; integrated security=SSPI";
            string commandString = @"SELECT * FROM Customers";
            SqlDataAdapter dataAdapter = new SqlDataAdapter( commandString, connectionString );

            DataSet myDataSet = new DataSet();
            dataAdapter.Fill( myDataSet, "Customers" );

            myDataSet.WriteXml( tempfile );
			Console.WriteLine( "Wrote Customer table to XML file {0}", tempfile );

            DataSet data2 = new DataSet();
            data2.ReadXml( tempfile );

            int nRows = data2.Tables["Customers"].Rows.Count;
			Console.WriteLine( "Read {0} records from XML file {1}", nRows, tempfile );
            // nRows is 91

			Console.WriteLine("Press ENTER to quit...");
			Console.ReadLine();
        }
    }
}
/*
 * The following example creates a System.IO.FileStream object. The object is then used with the WriteXml method to write an XML document.
 * 
private void WriteXmlToFile(DataSet thisDataSet) 
{
    if (thisDataSet == null) { return; }

    // Create a file name to write to. 
    string filename = "XmlDoc.xml";

    // Create the FileStream to write with.
    System.IO.FileStream stream = new System.IO.FileStream
        (filename, System.IO.FileMode.Create);

    // Write to the file with the WriteXml method.
    thisDataSet.WriteXml(stream);   
}
*/


/*
 * The following example first creates a simple DataSet with one DataTable, two columns, 
 * and ten rows. The DataSet schema and data are written to disk by invoking the WriteXml method. 
 * A second DataSet is created and the ReadXml method is used to fill it with schema and data.
 * 
private void DemonstrateReadWriteXMLDocumentWithFileStream()
{
    // Create a DataSet with one table and two columns.
    DataSet originalDataSet = new DataSet("dataSet");
    DataTable table = new DataTable("table");
    DataColumn idColumn = new DataColumn("id", 
        Type.GetType("System.Int32"));
    idColumn.AutoIncrement= true;

    DataColumn itemColumn = new DataColumn("item");
    table.Columns.Add(idColumn);
    table.Columns.Add(itemColumn);
    originalDataSet.Tables.Add(table);
    // Add ten rows.

    DataRow newRow;
    for(int i = 0; i < 10; i++)
    {
        newRow = table.NewRow();
        newRow["item"]= "item " + i;
        table.Rows.Add(newRow);
    }
    originalDataSet.AcceptChanges();

    // Print out values of each table in the DataSet   
    // using the function defined below.
    PrintValues(originalDataSet, "Original DataSet");

    // Write the schema and data to XML file with FileStream. 
    string xmlFilename = "XmlDocument.xml";
    System.IO.FileStream streamWrite = new System.IO.FileStream
        (xmlFilename, System.IO.FileMode.Create);

    // Use WriteXml to write the XML document.
    originalDataSet.WriteXml(streamWrite);

    // Close the FileStream.
    streamWrite.Close();

    // Dispose of the original DataSet.
    originalDataSet.Dispose();
    // Create a new DataSet.
    DataSet newDataSet = new DataSet("New DataSet");

    // Read the XML document back in.  
    // Create new FileStream to read schema with.
    System.IO.FileStream streamRead = new System.IO.FileStream
        (xmlFilename,System.IO.FileMode.Open);
    newDataSet.ReadXml(streamRead);

    // Print out values of each table in the DataSet  
    // using the function defined below.
    PrintValues(newDataSet,"New DataSet");
}

private void PrintValues(DataSet dataSet, string label)
{
    Console.WriteLine("\n" + label);
    foreach(DataTable table in dataSet.Tables)
    {
        Console.WriteLine("TableName: " + table.TableName);
        foreach(DataRow row in table.Rows)
        {
            foreach(DataColumn column in table.Columns)
            {
                Console.Write("\table " + row[column] );
            }
            Console.WriteLine();
        }
    }
}

 * 
 * 
 public static SqlDataAdapter CreateSqlDataAdapter(SqlCommand selectCommand,
    SqlConnection connection)
{
    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

    // Create the other commands.
    adapter.InsertCommand = new SqlCommand(
        "INSERT INTO Customers (CustomerID, CompanyName) " +
        "VALUES (@CustomerID, @CompanyName)", connection);

    adapter.UpdateCommand = new SqlCommand(
        "UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName " +
        "WHERE CustomerID = @oldCustomerID", connection);

    adapter.DeleteCommand = new SqlCommand(
        "DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);

    // Create the parameters.
    adapter.InsertCommand.Parameters.Add("@CustomerID", 
        SqlDbType.Char, 5, "CustomerID");
    adapter.InsertCommand.Parameters.Add("@CompanyName", 
        SqlDbType.VarChar, 40, "CompanyName");

    adapter.UpdateCommand.Parameters.Add("@CustomerID", 
        SqlDbType.Char, 5, "CustomerID");
    adapter.UpdateCommand.Parameters.Add("@CompanyName", 
        SqlDbType.VarChar, 40, "CompanyName");
    adapter.UpdateCommand.Parameters.Add("@oldCustomerID", 
        SqlDbType.Char, 5, "CustomerID").SourceVersion = DataRowVersion.Original;

    adapter.DeleteCommand.Parameters.Add("@CustomerID", 
        SqlDbType.Char, 5, "CustomerID").SourceVersion = DataRowVersion.Original;

    return adapter;
} // CreateSqlDataAdapter
 
 * 
 * 
 *public static SqlDataAdapter CreateSqlDataAdapter(SqlConnection connection)
{
    SqlDataAdapter adapter = new SqlDataAdapter();
    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

    // Create the commands.
    adapter.SelectCommand = new SqlCommand(
        "SELECT CustomerID, CompanyName FROM CUSTOMERS", connection);
    adapter.InsertCommand = new SqlCommand(
        "INSERT INTO Customers (CustomerID, CompanyName) " +
        "VALUES (@CustomerID, @CompanyName)", connection);
    adapter.UpdateCommand = new SqlCommand(
        "UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName " +
        "WHERE CustomerID = @oldCustomerID", connection);
    adapter.DeleteCommand = new SqlCommand(
        "DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);

    // Create the parameters.
    adapter.InsertCommand.Parameters.Add("@CustomerID", 
        SqlDbType.Char, 5, "CustomerID");
    adapter.InsertCommand.Parameters.Add("@CompanyName", 
        SqlDbType.VarChar, 40, "CompanyName");

    adapter.UpdateCommand.Parameters.Add("@CustomerID", 
        SqlDbType.Char, 5, "CustomerID");
    adapter.UpdateCommand.Parameters.Add("@CompanyName", 
        SqlDbType.VarChar, 40, "CompanyName");
    adapter.UpdateCommand.Parameters.Add("@oldCustomerID", 
        SqlDbType.Char, 5, "CustomerID").SourceVersion = 
        DataRowVersion.Original;

    adapter.DeleteCommand.Parameters.Add("@CustomerID", 
        SqlDbType.Char, 5, "CustomerID").SourceVersion = 
        DataRowVersion.Original;

    return adapter;
}
*/
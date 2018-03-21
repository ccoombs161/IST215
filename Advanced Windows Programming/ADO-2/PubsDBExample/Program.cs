using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace PopulateDataSet
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class PubsDBEXample
    {
        static void Main(string[] args)
        {
            string sConnectionString = "Password=BadDog99;User ID=sa;"
                                + "Initial Catalog=pubs;"
                                + "Data Source=(local)";
            //string sConnectionString = @"data source=localhost;initial catalog=pubs;integrated security=sspi";
            
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();

            SqlDataAdapter daAuthors
                = new SqlDataAdapter("Select * From Authors", objConn);
            DataSet dsPubs = new DataSet("Pubs");
            daAuthors.FillSchema(dsPubs, SchemaType.Source, "Authors");
            daAuthors.Fill(dsPubs, "Authors");
            
            DataTable tblAuthors;
            tblAuthors = dsPubs.Tables["Authors"];
            
            //Console.WriteLine("Testing " + tblAuthors.Rows[0].Field<string>("au_fname"));

            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                    drCurrent["au_fname"].ToString(),
                    drCurrent["au_lname"].ToString());
            }

            Console.WriteLine("\n\nNow with PrintRow method");
            PrintRows(dsPubs);

            Console.WriteLine("\n\nGetTableNames");
            GetTableNames(dsPubs);
            //Console.ReadLine();

            Console.WriteLine("\n\nGetPrimaryKeys");
            GetPrimaryKeys(tblAuthors);
            
            //Console.WriteLine("\n\nCheckForErrors");
            //CheckForErrors(dsPubs);

            Console.WriteLine("\n\nGetAndSetExtendedProperties");
            GetAndSetExtendedProperties(tblAuthors);

        } // end main
        private static void PrintRows(DataSet myDataSet)
        {
            // For each table in the DataSet, print the values of each row.

            foreach (DataTable thisTable in myDataSet.Tables)
            {
                // For each row, print the values of each column.
                foreach (DataRow myRow in thisTable.Rows)
                {
                    foreach (DataColumn myCol in thisTable.Columns)
                    {
                        Console.Write(myRow[myCol] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void GetTableNames(DataSet dataSet)
        {
            // Print each table's TableName. 
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine(table.TableName);
            }
        }

        private void AddARow(DataSet dataSet)
        {
            DataTable table;
            table = dataSet.Tables["Suppliers"];
            // Use the NewRow method to create a DataRow with  
            // the table's schema.
            DataRow newRow = table.NewRow();

            // Set values in the columns:
            newRow["CompanyID"] = "NewCompanyID";
            newRow["CompanyName"] = "NewCompanyName";

            // Add the row to the rows collection.
            table.Rows.Add(newRow);
        }

        private static void GetPrimaryKeys(DataTable table)
        {
            // Create the array for the columns.
            DataColumn[] columns;
            columns = table.PrimaryKey;

            // Get the number of elements in the array.
            Console.WriteLine("Column Count: " + columns.Length);
            for (int i = 0; i < columns.Length; i++)
            {
                Console.WriteLine(columns[i].ColumnName + columns[i].DataType);
            }
        }

        private static void SetPrimaryKeys()
        {
            // Create a new DataTable and set two DataColumn objects as primary keys.
            DataTable table = new DataTable();
            DataColumn[] keys = new DataColumn[2];
            DataColumn column;

            // Create column 1.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";

            // Add the column to the DataTable.Columns collection.
            table.Columns.Add(column);

            // Add the column to the array.
            keys[0] = column;

            // Create column 2 and add it to the array.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LastName";
            table.Columns.Add(column);

            // Add the column to the array.
            keys[1] = column;

            // Set the PrimaryKeys property to the array.
            table.PrimaryKey = keys;
        }

        private static void GetChildRowsFromDataRelation(DataTable table)
        {
            DataRow[] rowArray;
            foreach (DataRelation relation in table.ParentRelations)
            {
                foreach (DataRow row in table.Rows)
                {
                    rowArray = row.GetParentRows(relation);
                    // Print values of rows. 
                    for (int i = 0; i < rowArray.Length; i++)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(rowArray[i][column]);
                        }
                    }
                }
            }
        }

        /*
         * The MinimumCapacity allows the system to create an appropriate set of 
         * resources before fetching data. In a situation when performance is critical, 
         * setting this property can optimize performance.
         */
        private static void SetMinimumCapacity(DataTable table)
        {
            // Change the MinimumCapacity.
            table.MinimumCapacity = 100;
        }

        /* Gets or sets the locale information used to compare strings within the table.
         * A CultureInfo represents the software preferences of a particular culture or community.
         * When used for string comparisons, the CultureInfo affects sorting, comparisons, and filtering.
         */
        private static void ChangeCultureInfo(DataTable table)
        {
            // Print the LCID  of the present CultureInfo.
            Console.WriteLine(table.Locale.LCID);

            // Create a new CultureInfo for the United Kingdom.
            CultureInfo myCultureInfo = new CultureInfo("en-gb");
            table.Locale = myCultureInfo;

            // Print the new LCID.
            Console.WriteLine(table.Locale.LCID);
        }

        /*
         * Gets a value that indicates whether the DataTable is initialized
         * [BrowsableAttribute(false)]
         * public bool IsInitialized { get; }
         */

        /*
         * Gets a value indicating whether there are errors in any of the rows in any of the tables of the DataSet to which the table belongs.
         * 
         * As users work on a set of data contained in a DataTable, you can mark each change with an error
         * if the change causes some validation failure. You can mark an entire DataRow with an error 
         * message using the RowError property. You can also set errors on each column of the row with the SetColumnError method.
         * Before updating a data source with a DataSet, it's recommended that you first 
         * invoke the GetChanges method on the target DataSet. The method results 
         * in a DataSet that contains only the changes made to the original. 
         * Before sending the DataSet to the data source for updating, check the HasErrors 
         * property of each table to see if any errors have been attached to the rows or columns in the rows.
         * 
         * After reconciling each error, clear the errors with the ClearErrors method of the DataRow.
         * 
         */
        
        private static void CheckForErrors(DataSet dataSet)
        {
            // Invoke GetChanges on the DataSet to create a reduced set.
            DataSet thisDataSet = dataSet.GetChanges();

            // Check each table's HasErrors property. 
            foreach (DataTable table in thisDataSet.Tables)
            {
                // If HasErrors is true, reconcile errors. 
                if (table.HasErrors)
                {
                    // Insert code to reconcile errors.
                    Console.WriteLine("Found error!!");
                }
                else
                    Console.WriteLine("NO errors found!!");
            }
        }

        /*
         * Gets the collection of customized user information
         * The following example adds a timestamp value to 
         * the DataTable through the ExtendedProperties property.
         */
        private static void GetAndSetExtendedProperties(DataTable myTable)
        {
            // Add an item to the collection.
            myTable.ExtendedProperties.Add("TimeStamp", DateTime.Now);
            // Print the item.
            Console.WriteLine(myTable.ExtendedProperties["TimeStamp"]);
        }

        /*
         * The following example sets a property of the DataTable object's 
         * DataView through the DefaultView property. The example also shows 
         * the binding of a DataGridView control to a DataTable 
         * named "Suppliers" that includes a column named "CompanyName." 
         */
        //private void BindDataGrid()
        //{
        //    DataTable table = new DataTable();

        //    // Insert code to populate a DataTable with data. 

        //    // Bind grid to DataTable.
        //    dataGrid1.DataSource = table;
        //}

        //private void ChangeRowFilter()
        //{
        //    DataTable gridTable = (DataTable)dataGrid1.DataSource;

        //    // Set the RowFilter to display a company names that  
        //    // begin with A through I..
        //    gridTable.DefaultView.RowFilter = "CompanyName < 'I'";
        //}

        //The following example adds a ForeignKeyConstraint to the collection of constraints.
        private void CreateConstraint(DataSet dataSet,
            string table1, string table2, string column1, string column2)
        {
            ForeignKeyConstraint idKeyRestraint = new
                ForeignKeyConstraint(dataSet.Tables[table1].Columns[column1],
                dataSet.Tables[table2].Columns[column2]);

            // Set null values when a value is deleted.
            idKeyRestraint.DeleteRule = Rule.SetNull;
            idKeyRestraint.UpdateRule = Rule.Cascade;

            // Set AcceptRejectRule to cascade changes.
            idKeyRestraint.AcceptRejectRule = AcceptRejectRule.Cascade;

            dataSet.Tables[table1].Constraints.Add(idKeyRestraint);
            dataSet.EnforceConstraints = true;
        }

    }
}

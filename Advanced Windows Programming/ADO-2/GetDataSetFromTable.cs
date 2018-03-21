//If a control is data bound to a DataTable, and the table belongs to a DataSet, you can get to the DataSet through this property.
private DataSet GetDataSetFromTable()
{
    DataTable table;

    // Check to see if the DataGrid's DataSource 
    // is a DataTable. 
    if( dataGrid1.DataSource is DataTable)
    {
        table = (DataTable) dataGrid1.DataSource;
        // Return the DataTable's DataSet 
        return table.DataSet;
    }
    else
    {
        return null;
    }
}
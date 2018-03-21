protected void Page_Load(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("data source=.;uid=sa;pwd=123;database=shop");
    //SqlCommand cmd = new SqlCommand("select * from tblemployees", con);
    //SqlCommand cmd1 = new SqlCommand("select * from tblproducts", con);
    //SqlDataAdapter da = new SqlDataAdapter();

    //DataSet ds = new DataSet();
    //ds.Tables.Add("emp");
    //ds.Tables.Add("products");
    //da.SelectCommand = cmd;
    //da.Fill(ds.Tables["emp"]);
    //da.SelectCommand = cmd1;

    //da.Fill(ds.Tables["products"]);
    SqlDataAdapter da = new SqlDataAdapter("select * from tblemployees", con);
    DataSet ds = new DataSet();
    da.Fill(ds, "em");
    da = new SqlDataAdapter("select * from tblproducts", con);
    da.Fill(ds, "prod");

    GridView1.DataSource = ds.Tables["em"];
    GridView1.DataBind();
    GridView2.DataSource = ds.Tables["prod"];
    GridView2.DataBind();
}


DataSet someDataSet = new DataSet();
        SqlDataAdapter adapt = new SqlDataAdapter();

        using(SqlConnection connection = new SqlConnection(ConnString))
        {
            connection.Open();
            SqlCommand comm1 = new SqlCommand("SELECT * FROM whateverTable", connection);
            SqlCommand comm2g = new SqlCommand("SELECT * FROM whateverTable WHERE condition = @0", connection);
            commProcessing.Parameters.AddWithValue("@0", "value");
            someDataSet.Tables.Add("Table1");
            someDataSet.Tables.Add("Table2");

            adapt.SelectCommand = comm1;
            adapt.Fill(someDataSet.Tables["Table1"]);
            adapt.SelectCommand = comm2;
            adapt.Fill(someDataSet.Tables["Table2"]);
        }

/*
Filling a DataSet with multiple tables can be done by sending multiple
 requests to the database, or in a faster way: Multiple SELECT statements 
 can be sent to the database server in a single request. 
 The problem here is that the tables generated from the queries 
 have automatic names Table and Table1. However, the generated table 
 names can be mapped to names that should be used in the DataSet.
*/
SqlDataAdapter adapter = new SqlDataAdapter(
      "SELECT * FROM Customers; SELECT * FROM Orders", connection);
adapter.TableMappings.Add("Table", "Customer");
adapter.TableMappings.Add("Table1", "Order");

adapter.Fill(ds);



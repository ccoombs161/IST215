using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;

namespace MyDataContext
{ class Class1 
    {
    static void Main(string[] args) 
    {

        DataContext db = new DataContext(@"C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\northwnd_Temp.mdf");

        // Get a typed table to run queries.
        Table<Customer> Customers = db.GetTable<Customer>();

        // Query for customers from London.
        var query =
            from cust in Customers
            where cust.City == "London"
            select cust;

        foreach (var cust in query)
            Console.WriteLine("id = {0}, City = {1}", cust.CustomerID, cust.City);





    }
}

public partial class Northwind : DataContext
{
    public Table<Customer> Customers;
    public Table<Order> Orders;
    public Northwind(string connection) : base(connection) { }
}

}
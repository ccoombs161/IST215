using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstCustomerFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerOrderDBContext())
            {
                var query1 = from c in db.CUSTOMERs
                            join o in db.ORDERs
                            on c.CustomerID equals o.CustomerID
                            orderby o.CustomerID
                            select new
                            {
                                o.CustomerID,
                                CustomerName = c.CustomerName.Trim(),
                                o.OrderNum,
                                ProductName = o.ProductName.Trim()
                            };
                Console.WriteLine("\nAll customers orders, sorted by CustomerID.");
                query1.ToList().ForEach(i1 => Console.WriteLine($"{i1.CustomerID} {i1.CustomerName} " +
                    $" {i1.OrderNum} {i1.ProductName} "));
            }
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstCustomerOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerOrderDBContext())
            {
                var query = from b in db.CUSTOMERs
                            join o in db.ORDERs
                            on b.CustomerID equals o.CustomerID
                            orderby o.CustomerID
                            select new { o.CustomerID,
                                CustomerName = b.CustomerName.Trim(), o.OrderNum, ProductName = o.ProductName.Trim() };

                Console.WriteLine("All Customers in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName.Trim()} {item.ProductName.Trim()}, {item.ProductName}");
                }
                Console.WriteLine();
                foreach (var item in query)
                {
                    Console.WriteLine($"{item}");
                }

                /*
                 * UPDATE - Find Customer name "Jacobs, Nancy" and change her name to Yusuf, Mohammad
                 */
                var result = db.CUSTOMERs.SingleOrDefault(n => n.CustomerName.Equals("Jacobs, Nancy"));
                if (result != null)
                {
                    result.CustomerName = "Yusuf, Mohammad";
                    db.SaveChanges();
                }
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName.Trim()} {item.ProductName.Trim()}, {item.ProductName}");
                }

                /*
                 * ADD new Customer
                 */
                var customerName = new CUSTOMER {
                    CustomerName = "Beaton, Elizabeth", EmailDomain = "Somewhere.com", PhoneAreaCode = "222",
                    City = "Wilmington", State = "DE", ZIP = "12345"
                };
                Console.WriteLine($"Add 2 instances of Customer {customerName.CustomerName}");
                try
                {
                    db.CUSTOMERs.Add(customerName);
                    db.CUSTOMERs.Add(customerName);
                    db.SaveChanges();                       // need a save here
                }
                catch (Exception e)
                {

                    Console.WriteLine($"\n***Exception Occurred: {e.Message}\n****\n");
                }
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName.Trim()} {item.ProductName.Trim()}, {item.ProductName}");
                }

                /*
                var leftList = (from emp in Employees
                                join d in Departments
                                on emp.deptID equals d.Id into output
                                from j in output.DefaultIfEmpty()
                                select new
                                {
                                    id = emp.Id,
                                    name = emp.name,
                                    datejoin = emp.datejoin,
                                     deptname = d.name });

                */
                Console.WriteLine("\n\nBefore attempting the join");
                var query2 = 
                    from cust in db.CUSTOMERs join o in db.ORDERs
                        on cust.CustomerID equals o.CustomerID into CustomersAndOrders      // place resuts in order
                    from ord in CustomersAndOrders.DefaultIfEmpty()         // Customers who do not have orders will have null orders
                    select new                                              // Create a new anonymous object that customers and order info.
                    {
                        cust.CustomerID,                                // Using existing field
                        CustomerName = cust.CustomerName.Trim(),        // creating a new field
                        OrderNum = (ord == null) ? -1 : ord.OrderNum,   // if customer does not have an order
                        // ProductName = (ord == null) ? String.Empty : ord.ProductName.Trim()
                        ProductName = (ord == null) ? "Customer without order" : ord.ProductName.Trim()
                    };

                foreach (var item in query2)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName} {item.OrderNum} {item.ProductName.Trim()}");
                }

                /*
                 * DELETE new Customer
                 */
                Console.WriteLine($"Remove Customer {customerName.CustomerName}");
                try
                {
                    CUSTOMER thisCustomer = (CUSTOMER) db.CUSTOMERs.Where(c => c.CustomerName == "Beaton, Elizabeth").First();
                    db.CUSTOMERs.Remove(thisCustomer);
                    db.SaveChanges();
                    
                    //List<CUSTOMER> customerList = new List<CUSTOMER>();
                    //customerList.Add ((CUSTOMER)db.CUSTOMERs.Where(c => c.CustomerName == "Beaton, Elizabeth"));
                    //customerList.ForEach(c => db.CUSTOMERs.Remove(c));
                }
                catch (Exception e)
                {

                    Console.WriteLine($"\n***Exception Occurred: {e.StackTrace}\n****\n");
                }

                /*
                 * DELETE ALL Customers with Name
                 */
                Console.WriteLine($"Remove all instance of {customerName.CustomerName}");
                db.Database.ExecuteSqlCommand(@"DELETE FROM CUSTOMER WHERE CustomerName = 'Beaton, Elizabeth'");


                foreach (var item in query)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName.Trim()} {item.ProductName.Trim()}, {item.ProductName}");
                }
                Console.WriteLine("\n\nAfter attempting the join");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

    }
}

/*
 * 
 *                 Console.WriteLine("\n\nBefore attempting the join");
                var query2 = (
                    from b in db.CUSTOMERs
                    join o in db.ORDERs
                    on b.CustomerID equals o.CustomerID into output
                    from j in output.DefaultIfEmpty()
                    select new
                    {
                        j.CustomerID,
                        CustomerName = b.CustomerName.Trim(),
                        j.OrderNum,
                        ProductName = j.ProductName.Trim()
                    });
                
                foreach (var item in query2)
                {
                    Console.WriteLine($"{item.CustomerID} {item.CustomerName.Trim()} {item.ProductName.Trim()}, {item.ProductName}");
                }

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CUSTOMER_ORDEREntities())
            {
                var query1 = from c in db.CUSTOMERs
                             join o in db.ORDERs
                             on c.CustomerID equals o.CustomerID
                             orderby c.CustomerID
                             select new
                             {
                                 o.CustomerID,
                                 CustomerName = c.CustomerName.Trim(),
                                 o.OrderNum,
                                 ProductName = o.ProductName.Trim()
                             };
                Console.WriteLine($"CustomerID OrderNum {"CustomerName",20} {"Product Name", -30}");
                query1.ToList().ForEach(x => Console.WriteLine(x));

                Console.WriteLine("\nUPDATE - Find Customer \"Jacobs,Nancy\" change it to Marcus Quimby");
                var result = db.CUSTOMERs.SingleOrDefault(n => n.CustomerName.Equals("Jacobs, Nancy"));
                if (result != null)
                {
                    result.CustomerName = "Quimby, Marcus";
                    db.SaveChanges();
                }
                query1.ToList().ForEach(x => Console.WriteLine(x));

                //Console.WriteLine("\nAdd a new customer Nick Skoolicas");
                Console.WriteLine("\nAdd a new customer Homer Simpson");
                var customer = new CUSTOMER {

                    // CustomerName = "Skoolicas, Nickalus", EmailDomain = "nick@somewhere.com", PhoneAreaCode = "222",
                    CustomerName = "Simspon, Bart",
                    EmailDomain = "Homer2@simpsons.com",
                    PhoneAreaCode = "222",
                    City = "Concord", State = "NH", ZIP = "03301"
                };
                try
                {
                    db.CUSTOMERs.Add(customer);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}\n{e.StackTrace}");
                    
                }
                
                    
            }
                
        }
    }
}

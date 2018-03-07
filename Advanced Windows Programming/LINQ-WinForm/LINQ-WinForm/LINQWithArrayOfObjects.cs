using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_WinForm
{
    class LINQWithArrayOfObjects 
    {
        static void Employees()
        {
            var employees = new[]
            {
               new Employee("Jason", "Red", 5000M),
               new Employee("Ashley", "Green", 7600M),
               new Employee("Matthew", "Indigo", 3587.5M),
               new Employee("James", "Indigo", 4700.77M),
               new Employee("Luke", "Indigo", 6200M),
               new Employee("Jason", "Blue", 1200M),
               new Employee("Jacob", "Blue", 3200M),
               new Employee("James", "Blue", 7200M),
               new Employee("Wendy", "Brown", 4236.4M)
            };

            Console.WriteLine("Display All Employees");
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

            var between0K6K =
                from e in employees
                where (e.MonthlySalary >= 0000M) && (e.MonthlySalary <= 6000M)
                select e;

            var between72K75K =
                from e in employees
                where (e.MonthlySalary >= 7200M) && (e.MonthlySalary <= 7500M)
                select e;

            var between0K10K =
               from e in employees
               where (e.MonthlySalary >= 0000M) && (e.MonthlySalary <= 10000M)
               select e;

            var nameSorted =
                from e in employees
                orderby e.LastName, e.FirstName
                select e;

            if (nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("not found");
            }

            var lastNames =
                from e in employees
                select e.LastName;

            var names =
                from e in employees
                select new { e.FirstName, e.LastName };
        }
    }
}

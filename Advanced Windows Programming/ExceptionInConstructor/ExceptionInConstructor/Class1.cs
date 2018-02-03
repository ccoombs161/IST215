using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInConstructor
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                NumberValidator nv = new NumberValidator(5);
                NumberValidator nv1 = new NumberValidator(11);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            Console.WriteLine("Program ended successfully");
        }
    }
}

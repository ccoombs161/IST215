using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deeply_Nested_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithNestedMethods cm = new ClassWithNestedMethods();

            try
            {
                cm.MethodA();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("The stack trace for this exception is:");
                Console.WriteLine(ex.StackTrace);
            }
        }// end Main
    } // end Class
} // end NameSpace

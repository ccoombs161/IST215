using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInConstructor
{
    class NumberValidator
    {
       public NumberValidator(int num)
        {
            if (num < 11)
            {
                Console.WriteLine("Number {0} is valid.", num);
            }
            else
            {
                string msg =
                    String.Format("{0} is invalid. Number must be less than or equal to 10.\n", num);
                throw new ArithmeticException(msg);
            }
        }
    }
}

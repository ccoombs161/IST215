using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deeply_Nested_Class
{
    class MyException : Exception
    {
        public MyException()
            : base("My Custom Exception.")
        {
            // Exception GOes here 
        } // end default constructor 

        public MyException(string messageValue)
            : base(messageValue)
        {
            // empty for now
        }

        public MyException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {
            // empty for now
        }
    } // end class 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseandDervClasses
{
    class ExceptionA : Exception
    {
        public ExceptionA()
            : base("Exception thrown by Exception Class ExceptionA")
        {
            Console.WriteLine("ExceptionA(): In body of exception A.");
        }

        public ExceptionA(string msg)
            : base(msg)
        {
            Console.WriteLine("ExceptionA(string msg): In body of exception A.");
        }
        public ExceptionA(string msg, Exception inner)
            : base(msg, inner)
        {
            Console.WriteLine("ExceptionA(string msg, Exception inner): In body of exception A.");
        }

    } // end class ExceptionA
}

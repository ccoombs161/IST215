using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseandDervClasses
{
    class ExceptionB : ExceptionA
    {   public ExceptionB()
        : base("Exception thrown by Exception Class ExceptionB")
        {
            Console.WriteLine("ExceptionB(): In body of exception B.");
        }

        public ExceptionB(string msg)
            : base(msg)
        {
            Console.WriteLine("ExceptionB(string msg): In body of exception B.");
        }
        public ExceptionB(string msg, Exception inner)
            : base(msg, inner)
        {
            Console.WriteLine("ExceptionB(string msg, Exception inner): In body of exception B.");
        }
    } // end class ExceptionB
}

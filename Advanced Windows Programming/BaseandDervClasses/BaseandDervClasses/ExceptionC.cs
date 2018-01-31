using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseandDervClasses
{
    class ExceptionC : ExceptionB
    {
            public ExceptionC()
            : base("Exception thrown by Exception Class ExceptionC")
            {
                Console.WriteLine("ExceptionC(): In body of exception C.");
            }

            public ExceptionC(string msg)
                : base(msg)
            {
                Console.WriteLine("ExceptionB(string msg): In body of exception B.");
            }
            public ExceptionC(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionB(string msg, Exception inner): In body of exception B.");
            }
        } // end class ExceptionC
    }

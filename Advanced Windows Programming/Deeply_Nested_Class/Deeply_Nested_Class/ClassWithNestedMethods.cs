using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deeply_Nested_Class
{
    class ClassWithNestedMethods
    {
        class ExceptionA : Exception
        {
            public ExceptionA()
            : base("Exception thrown by Exception Class ExceptionA")
            {
                Console.WriteLine("ExceptionB(): In body of exception A.");
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
        }
        class ExceptionB : ExceptionA
        {
            public ExceptionB()
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
        }

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
                Console.WriteLine("ExceptionC(string msg): In body of exception C.");
            }
            public ExceptionC(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionC(string msg, Exception inner): In body of exception C.");
            }
        }

        class ExceptionD : ExceptionC
        {
            public ExceptionD()
            : base("Exception thrown by Exception Class ExceptionD")
            {
                Console.WriteLine("ExceptionD(): In body of exception D.");
            }

            public ExceptionD(string msg)
                : base(msg)
            {
                Console.WriteLine("ExceptionD(string msg): In body of exception D.");
            }
            public ExceptionD(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionD(string msg, Exception inner): In body of exception D.");
            }
        }
        class ExceptionE : ExceptionD
        {
            public ExceptionE()
            : base("Exception thrown by Exception Class ExceptionE")
            {
                Console.WriteLine("ExceptionE(): In body of exception E.");
            }

            public ExceptionE(string msg)
                : base(msg)
            {
                Console.WriteLine("ExceptionE(string msg): In body of exception E.");
            }
            public ExceptionE(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionE(string msg, Exception inner): In body of exception E.");
            }
        }

        class ExceptionF : ExceptionE
        {
            public ExceptionF()
            : base("Exception thrown by Exception Class ExceptionF")
            {
                Console.WriteLine("ExceptionF(): In body of exception F.");
            }

            public ExceptionF(string msg)
                : base(msg)
            {
                Console.WriteLine("ExceptionF(string msg): In body of exception F.");
            }
            public ExceptionF(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionF(string msg, Exception inner): In body of exception F.");
            }
        }

        class ExceptionG : ExceptionF
        {
            public ExceptionG()
            : base("Exception thrown by Exception Class ExceptionG")
            {
                Console.WriteLine("ExceptionG(): In body of exception G.");
            }

            public ExceptionG(string msg)
                : base(msg)
            {
                Console.WriteLine("ExceptionG(string msg): In body of exception G.");
            }
            public ExceptionG(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionG(string msg, Exception inner): In body of exception G.");
            }
        }

        class ExceptionH : ExceptionG
        {
            public ExceptionH()
            : base("Exception thrown by Exception Class ExceptionH")
            {
                Console.WriteLine("ExceptionH(): In body of exception H.");
            }

            public ExceptionH(string msg)
                : base(msg)
            {
                Console.WriteLine("ExceptionH(string msg): In body of exception H.");
            }
            public ExceptionH(string msg, Exception inner)
                : base(msg, inner)
            {
                Console.WriteLine("ExceptionH(string msg, Exception inner): In body of exception H.");
            }
        }
    }
}

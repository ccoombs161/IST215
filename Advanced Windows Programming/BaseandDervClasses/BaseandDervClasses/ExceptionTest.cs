using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseandDervClasses
{
   public class ExceptionTest
    {
        public static void Main(string[] args)
        {
            // 1 throw and catch an ExceptionC exception
            try
            {
                Console.WriteLine("\n1) Throw a base class exception, ExceptionA");
                throw new ExceptionA();
            } // end try
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
            } // end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
            } // end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } // end catch

            try
            {
                // throw derived-class ExceptionB
                Console.WriteLine("\n\n2) Throw a derived-class ExceptionB");
                throw new ExceptionB();
            } // end try
            catch (ExceptionA ex)
            {
                Console.WriteLine("\n\nExceptionB caught in ExceptionA " +
                    "catch block: \n" + ex + "\n");
            } // end catch

            try
            {
                // throw derived-class ExceptionC
                Console.WriteLine("\n\n3) Throw a derived-class Exception C:");
                throw new ExceptionC("Exception C occurred...");
            } // end try
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
            } // end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            } // end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } // end catch

            try
            {
                // throw derived-class ExceptionC
                Console.WriteLine("\n\n4) InnerException. Calling method that throws Exception.");
                MethodThatThrowsException();
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
            } // end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            } // end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } // end catch

            Console.WriteLine("\n\nProgramming Ending successfully");
        } // end Main

        public static void MethodThatThrowsException()
        {
            /* 4
             * Throw a derived class exception. Cathc it in Catch block
             * and then re-throw an exception to show inner exception
            */
            try
            {
                // throw derived-class ExceptionC
                Console.WriteLine("Inside method, about to throw Exception C:");
                throw new ExceptionC("Exception C occurred...");
            }
            catch (ExceptionC ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionC\n" + ex + "\n");
                throw new ExceptionC("Caught exception, re-throwing it back", ex);
            } // end catch
            catch (ExceptionB ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionB\n" + ex + "\n");
            } // end catch
            catch (ExceptionA ex)
            {
                Console.WriteLine("Caught by catch block that has ExceptionA\n" + ex + "\n");
            } // end catch
        } // end Method
    }
}

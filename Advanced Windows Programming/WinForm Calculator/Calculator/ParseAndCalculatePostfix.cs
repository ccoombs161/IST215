using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ParseAndCalculatePostfix
    {
        private Stack theStack;
        private List<object> input;
        private List<object> output;
        public double result;

        public ParseAndCalculatePostfix(List<object> s)
        {
            theStack = new Stack();
            input = s;
            output = new List<object>();
        }


        public double doParse()
        {
            theStack = new Stack();      // make the new stack
            int j;
            double num1, num2;

            bool res;
            object temp;
            for (j = 0; j < input.Count; j++)   // for each char,
            {
                //Get a new value. If it is a number, push it on the stack
                temp = input[j];  //get new value. See if it is a numner
                double num;     //do this to make sure that it is a number
                res = Double.TryParse(temp.ToString(), out num);
                if (res)
                {
                    theStack.Push((double)num);
                }
                else         // it is not a number. It's an operator
                {
                    num2 = (double) theStack.Pop();   // pop 2 operands and do the math and them pop result back.
                    num1 = (double) theStack.Pop();   // No error checking. if code is written well, num will be double
                    
                    switch (temp.ToString())                // time to do the math
                    {
                        case "+":
                            result = num1 + num2;
                            Console.Write("{0} + {1} = {2}\n", num1, num2, result);
                            break;
                        case "-":
                            result = num1 - num2;
                            Console.Write("{0} - {1} = {2}\n", num1, num2, result);
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.Write("{0} * {1} = {2}\n", num1, num2, result);
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.Write("{0} / {1} = {2}\n", num1, num2, result);
                            break;
                        default:
                            result = 0;
                            Console.Write("Error: In Default, ch='{0}'\n", temp.ToString());
                            break;
                    }  // end switch                    
                    theStack.Push(result);        // push result
                }  // end else
            }  // end for
            res = Double.TryParse(theStack.Pop().ToString(), out result);            // get answer
            if (!(res))
                Console.WriteLine("Result from the stack was not a double");
            return result;
        }  // end doParse()
   

    }  // end class ParsePost
}
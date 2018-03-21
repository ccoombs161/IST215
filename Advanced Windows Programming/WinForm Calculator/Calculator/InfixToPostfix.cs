using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class InfixToPostfix                  // infix to postfix conversion
    {
        private Stack theStack;
        private List<object> input;
        private List<object> output;
        private int length;

        public InfixToPostfix(List<object> s)   // constructor
        {
            theStack = new Stack();
            input = s;
            length = s.Count;
            output = new List<object>();
        }

       
        public List<object> ConvertToPostfix()      // Convert to postfix
        {
            for (int j = 0; j < input.Count; j++)   // for each char
            {
                object next = input[j];            // get it char from input
                if (next.GetType().Equals("a".GetType()))
                {
                    switch (next.ToString())
                    {
                        case "+":               // it's + or -
                        case "-":
                            gotOper(next, 1);     // go pop operators
                            break;              //   (precedence 1)
                        case "*":               // it's * or /
                        case "/":
                            gotOper(next, 2);     // go pop operators
                            break;              //   (precedence 2)
                        case "(":               // it's a left paren
                            theStack.Push(next);  // push it
                            break;
                        case ")":               // it's a right paren
                            gotParen(next);       // go pop operators
                            break;
                        default:                // must be an operand
                            //outTempArr = outTempArr. + inTempArr[j]; // write it to output
                            break;
                    }  // end switch
                } // end if
                else
                {
                    output.Add(input[j]); // write it to output
                }
            }  // end for

            while (theStack.Count > 0)      // pop remaining opers
            {
                output.Add (theStack.Pop()); // write to output
            }
            return output;                   // return postfix
        }  // end ConvertToPostfix()
        
        public void gotOper(object opThis, int prec1)
        {                                // got operator from input
            while (theStack.Count > 0)
            {
                object opTop = theStack.Pop();
                //double num;
                //bool result = Double.TryParse(opTop.ToString(), out num);

                if (opTop.ToString() == "(")            // if it's a '('
                {
                    theStack.Push(opTop);      // restore '('
                    break;
                }
                else                          // it's an operator
                {
                    int prec2;                // precedence of new op

                    if (opTop.ToString() == "+" || opTop.ToString() == "-")  // find new op prec
                        prec2 = 1;
                    else
                        prec2 = 2;

                    if (prec2 < prec1)          // if prec of new op less
                    {                           // than prec of old
                        theStack.Push(opTop);   // save newly-popped op
                        break;
                    }
                    else                        // prec of new not less
                        output.Add(opTop);  // than prec of old
                }  // end else (it's an operator)
            }  // end while
            theStack.Push(opThis);           // push new operator
        }  // end gotOp()
        
        public void gotParen(object ch)
        {                             // got right paren from input
            while (theStack.Count > 0)
            {
                object chx = theStack.Pop();
                if (chx.ToString() == (string) "(")           // if popped '('
                    break;                  // we're done
                else                       // if popped operator
                    output.Add(chx);  // output it
            }  // end while
        }  // end popOps()
        
    }  // end class InToPost
}

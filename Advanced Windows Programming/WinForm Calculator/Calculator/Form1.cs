using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private static string input;
        private static List<object> postFixList;
        double output;

        public Form1()
        {
            InitializeComponent();
            TextBox1.SelectAll();
        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {
            
            input = TextBox1.Text;
            
            
            //if user entered an empty string or less than 2 operands and one operator
            if (input.Equals("") || string.IsNullOrEmpty(input) || input.Length < 3)
                return;

            //Convert infix to post fix notation. No error handling
            // objInpArray = CharToObjectArray(input);
            List<object> tempList = CharToObjectArray(input);
            InfixToPostfix converter = new InfixToPostfix(tempList);
            postFixList = converter.ConvertToPostfix(); // do the translation
            Console.WriteLine("Postfix:");
            //DisplaytheList(postFixList);

            //Take the postfix and evaluate the result.
            ParseAndCalculatePostfix theParser = new ParseAndCalculatePostfix(postFixList);
            output = theParser.doParse();  // do the evaluation
            TextBox1.Text += "\r\n= " + output.ToString();
            //TextBox1.SelectAll();
        }
        public static List<object> CharToObjectArray(string s)
        {
            List<object> thisList = new List<object>();

            s = s.Replace("+", " + ");  // it is still a char array or a string
            s = s.Replace("*", " * ");
            s = s.Replace("-", " - ");
            s = s.Replace("/", " / ");
            s = s.Replace("%", " % ");
            s = s.Replace("(", " ( ");
            s = s.Replace(")", " ) ");

            // remove spaces. New string is now a string array instead of char array
            // it can hold multi-digit numbers. Before it could only hod single digit.
            string[] inpArr = s.Split(' ');

            // now put content into an object array. Make all numbers double and
            // sybols and puncuations chars.

            double num;
            for (int i = 0; i < inpArr.Length; i++)
            {
                object temp = inpArr[i];


                bool isDouble = Double.TryParse(temp.ToString(), out num);
                if (isDouble)
                {
                    thisList.Add(Convert.ToDouble(inpArr[i]));
                }
                else
                {
                    thisList.Add(Convert.ToString(inpArr[i]));
                }
            }

            // Console.WriteLine("Constructor: New array {0}", objInpArray);
            return thisList;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "3";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "6";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "5";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "4";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "9";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "8";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "7";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "0";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox1.Focus();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "/";
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "*";
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "-";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "+";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ".";
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete)) 
            {
                TextBox1.Clear();
                TextBox1.Focus();
                TextBox1.SelectAll();
            }

        }

        private void ButtonClearEntry_Click(object sender, EventArgs e)
        {
            string oldText = TextBox1.Text;
            TextBox1.Text = oldText.Remove(oldText.Length-1, 1);
        }

        private void ButtonLParen_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "(";
        }

        private void ButtonRParen_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ")";
        }
    }
}

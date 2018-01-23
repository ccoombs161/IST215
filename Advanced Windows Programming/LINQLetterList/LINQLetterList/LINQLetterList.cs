using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLetterList
{
   public class LINQLetterList
    {
        static void Main(string[] args)
        {
            List<char> theList = new List<char>(); // create character list
            // Create random number generator
            Random randomNumber = new Random();

            // index into the alphabet to convert
            // numbers 0-25 to letters a-z
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            // generate 30 random letters 
            for (int i = 0; i < 30; i++)
            {
                // generate number from 0-25 to
                // select a letter from the string 
                int index = randomNumber.Next( 26 );

                // convert the letter number to the actual letter 
                char letter = alphabet[index];
                theList.Add( letter ); 
            } // end for

            Console.WriteLine("\nGenerated List:");
            foreach (var item in theList)
                Console.Write( "{0}", item );

            // sort theList in ascending order (the default)
            var ascending =
                from letter in theList
                orderby letter
                select letter;

            // display ascending order 
            Console.WriteLine("\n\nAscending order:");
            foreach ( var item in ascending )
                Console.Write("{0}", item);

            // sort the list in descending order 
            var descending =
                from letter in theList
                orderby letter descending
                select letter;

            // display descending order 
            Console.WriteLine("\n\nDescending order:");
            foreach (var item in descending)
                Console.Write("{0}", item);

            // display distinct letters in the list in ascending order 
            Console.WriteLine("\n\nAscending order, no duplicates:");
            foreach (var item in ascending.Distinct() )
                Console.Write("{0}", item);

            Console.WriteLine();
        } // end Main
    } // end class LINQLetterList
} // end namespace

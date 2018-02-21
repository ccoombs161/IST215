using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array.
            string[] array = { "banana", "apple", "peach", "cherry", "strawberry" };
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango",
                                "grape", "orange", "blueberry", "passionfruit", "strawberry" };

            var result = array.OrderBy(a => new string(a.ToCharArray()));
            Display(result, "a) Sort using OrderBy extension method, then display"); //Display results

            IEnumerable<string> arrayReversed = array.Reverse();
            Display(arrayReversed, "b) Reverst Sort the string and then display");

            var asc = from st in array
                      orderby st
                      select st;
            Display(asc, "c) Sort in ascending order using LINQ");

            var desc = from st in array
                      orderby st
                      select st;

            Display(desc, "d) Sort in descending order using LINQ");

            string[] reversed2 = RevereEachString(array);
            Display(reversed2, "e) Reverse each string in the array and dsiplay");

            string[] newArr = UpperCaseFirstChar(array);
            Display(newArr, "f) For each string, upper case first character");

            var reversed3 = string.Join(" ", array[0]
                                    .Split(' ')
                                    .Select(x => new String(x.Reverse().ToArray())));

            Display(reversed3, "g) Reverse word");

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);
            Display(query, "h) Use of 'Where' clause to select fruits with length less than 6.");

            IEnumerable<string> query2 = fruits.Where((num) => num.Contains("e"));
            Display(query2, "i) Use of 'Where' clause to select fruits that contain e.");

            IEnumerable<string> query3 = fruits.Where((num, index) => num.Contains("e") && index < 5);
            Display(query3, "j) Use of 'Where' clause to select fruits that contain 'e' and index < 5.");

            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
            Display(squares, "k) Use of 'Enumerable.Range and Select'");

            var query4 = fruits.Select((fruit, index) =>
               new { index, str = fruit.Substring(0, index) });
            Display(query4, "L) Use 'Select' to project over a sequence of values and use the index" +
                " of each element.");

            Console.WriteLine("\nSuppose a corporation has many sites, each identified by siteIDs");
            Console.WriteLine("They have various programs that use sites");
            string[] sites = { "1", "2", "4-8", "3-15" };
            string[] expandedSites = ExpandIDs(sites);
            sites.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            Console.WriteLine("\nExpanded Sites:");
            expandedSites.ToList().ForEach(x => Console.Write(x + " "));

            Console.WriteLine("\n0) Sites seperated by commas.");
            Console.WriteLine(string.Join(", ", expandedSites));

            Console.WriteLine("\nP) Sites are joined.");
            Console.WriteLine(string.Join("", expandedSites));

            string str = "1 2334";
            Console.WriteLine($"\nQ) Is this valid numeric string (can have spaces)? {str}");
            IsNumOnlyOrWhiteSpace(str);

            str = "12334";
            Console.WriteLine($"\nR) Is this valid numeric string (can have spaces)? {str}");
            IsNumOnlyOrWhiteSpace(str);

            str = "123-34";
            Console.WriteLine($"\nS) Is this valid numeric string (can have spaces)? {str}");
            IsNumOnlyOrWhiteSpace(str);
        } // end main

        static void Display<T>(IEnumerable<T> str, string msg)
        {
            Console.WriteLine(msg);
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static string[] RevereEachString(string[] arr)
        {
            string[] targetArray = new string[arr.Length];

            arr.CopyTo(targetArray, 0);

            for (int i = 0; i < arr.Length; i++)
            {
                targetArray[i] = ReverseString(arr[i]);

            }
            return targetArray;
               
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string UpperCaseFirstChar(string str) => $"{char.ToUpper(str[0])}{str.Remove(0, 1)}";

        static string[] UpperCaseFirstChar(string[] str)
        {
            string[] newStr = new string[str.Length];
            str.CopyTo(newStr, 0);

            for ( int i = 0; i < newStr.Length; i++)
            {
                newStr[i] = string.Format("{0}{1}", char.ToUpper(str[i][0]), str[i].Remove(0, 1));
            }
            return newStr;
        }
        public static string Reverse(string x)
        {
            char[] charArray = new char[x.Length];
            int len = x.Length - 1;
            for (int i = 0; i <= len; i++)
                charArray[i] = x[len - i];
            return new string(charArray);
        }
        private static string[] ExpandIDs(string[] ids)
        {
            List<string> result = new List<string>();
            foreach (string part in ids)
            {
                int i = part.IndexOf('-');
                if ( i == -1)
                {
                    result.Add(part);
                }
                else
                {
                    string min = part.Substring(0, i);
                    string max = part.Substring(i + 1);
                    int iMin = Convert.ToInt32(min);
                    int iMax = Convert.ToInt32(max);
                    for (i = iMin; i <= iMax; i++)
                    {
                        result.Add(i.ToString());
                    }
                }
            } // end foreach

            var noDupes = result.Distinct().ToList().OrderBy(x => int.Parse(x));
            return noDupes.ToArray<string>();
        }
        public static void IsNumOnlyOrWhiteSpace(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Null string.");
                return;
            }

            if (str.ToCharArray().All(c => Char.IsNumber(c) || Char.IsWhiteSpace(c)))
            {
                Console.WriteLine("Valid string. Has all numeric or space characters");
            }
            else
            {
                Console.WriteLine("inValid string. Has some non-numeric characters");

            }
            return;
        }
    }
}

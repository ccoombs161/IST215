using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx_Phone
{
	class Program
	{
		static void Main(string[] args)
		{
			// enter a phone numner in format (603) 555-1212
			string input = @"(603) 555-1212";
			Console.WriteLine($"Input string: {input}");


			// passing input string a patter that matches 
			Match result = Regex.Match(input, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");

			// GroupCollection returns the set of captured groups for a single match
			GroupCollection gc = null;
			if (!result.Success)
			{
				Console.WriteLine("Invalid Input");
				return;
			}
			else
			{
				Console.WriteLine("\nSingle Match: {0}\n", result.Value);

				gc = result.Groups;
				Console.WriteLine($"Count for the match: {gc.Count}, Original number: {result.Groups[0]}");
				string str = string.Format("{0}.{1}.{2}", result.Groups[1], result.Groups[2], result.Groups[3]);
				Console.WriteLine(str);

				input = "603-555-1212";
				Console.WriteLine($"\n\nInput string: {input}");
				str = ConvertPhoneNumber(input);
				Console.WriteLine($"{str}");
			}
		}

		static string ConvertPhoneNumber(string input)
		{
			try
			{
				return Regex.Replace(input,
					"\\b(?<areaCode>\\d{1,3})-(?<first>\\d{1,3})-(?<second>\\d" +
					"{1,4})\\b",
					"${areaCode}.${first}.${second}", RegexOptions.None,
					TimeSpan.FromMilliseconds(150));

			}
			catch (RegexMatchTimeoutException)
			{
				return input;
			}
		}
	}
}

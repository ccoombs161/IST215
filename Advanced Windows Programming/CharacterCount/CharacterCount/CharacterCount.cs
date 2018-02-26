using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CharacterCount
{
	class CharacterCount
	{
		static void Main(string[] args)
		{
			int digits, words, nonwords, whitespace; // character counters

			// get sentence
			Console.WriteLine("Please enter a sentence:");
			string sentence = Console.ReadLine();

			digits = Regex.Matches(sentence, @"\d").Count;

			words = Regex.Matches(sentence, @"\w").Count;

			nonwords = Regex.Matches(sentence, @"\W").Count;

			whitespace = Regex.Matches(sentence, @"\s").Count;

			// display results 
			Console.WriteLine($"\nDigits: {digits}, " +
				$"word chars: {words}, non-word chars: {nonwords}, whitespace chars: {whitespace}.");
		} // end main
	} // end class CHaracterCount
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstonePigLatin
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello and welcome to the Pig Latin anslatortray");
			Console.WriteLine("Please type the word that you would like to translate");
			string vowels = ("aeiou");
			string word = Console.ReadLine().ToLower();
			string firstLetter = word.Substring(0, 1);
			if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u")
			{
				Console.WriteLine(word + "way");
			}
			else
				Consonent();
		

			Console.ReadKey();
		}


		static string Consonent(string word)
		{
			string vowels = ("aeiou");
			
			string firstLetter = word.Substring(0, 1);
			for (int i = 0; i < word.Length; i++)
			{
				for (int j = 0; j < vowels.Length; j++)
				{
					if (word[i] == vowels[j])
					{
						int vowelPosition = i;
						string consonent = word.Substring(0, vowelPosition);
						string end = word.Substring(vowelPosition, word.Length - vowelPosition - 1);

						return end + consonent + "ay";
						
					}
					else return "no vowels";
					

				}
			}

		}


	}
}

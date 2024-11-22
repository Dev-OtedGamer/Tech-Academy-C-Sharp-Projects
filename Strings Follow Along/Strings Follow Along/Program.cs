using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
	class Program
	{
		static void Main(string[] args)
		{
			//string name = "Jesse";
			//string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
			//string fileName = @"C:\User\Jesse";

			//bool trueOrFalse = name.Contains("s");
			//trueOrFalse = name.EndsWith("s");

			//int length = name.Length;

			//name = name.ToLower();


			//Console.WriteLine(name);
			//Console.ReadLine();

			//StringBuilder sb = new StringBuilder();

			//sb.Append("My name is Jesse");

			//string name = "Jesse";
			//name = "Joe";


			//Console.WriteLine(sb);
			//Console.ReadLine();

			Console.WriteLine("String Manipulation in C#\n");

			//1.Concatenate three strings (Combining strings)
			string part1 = "This is how";
			string part2 = " we manipulate";
			string part3 = " strings in C#";
			string concatenated = part1 + part2 + part3;
			Console.WriteLine("Concatenated String");
			Console.WriteLine(concatenated);

			//2.Convert a string to uppercase
			Console.WriteLine("\nString in uppercase");
			string upperCaseString = concatenated.ToUpper();
			Console.WriteLine(upperCaseString);

			//3.Use a StringBuilder to build a paragraph
			Console.WriteLine("\nBuilding a Paragraph with StringBuilder:");
			StringBuilder paragraph = new StringBuilder();

			paragraph.Append("Learning how to work with strings in C#.");
			paragraph.Append(" In step one we used \"Concatenate\" to combine three strings into one.");
			paragraph.Append(" In step two we used \"Uppercase\" to change the string into all upercase.");
			paragraph.Append(" In Step three we used \"StringBuilder\" to create this paragraph.");

			Console.WriteLine(paragraph.ToString());
			Console.ReadLine();


		}
	}
}

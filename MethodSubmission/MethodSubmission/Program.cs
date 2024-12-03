using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//
				Math math = new Math();

				Console.WriteLine("Please enter a number we can do some math operations on.");
				int userInput = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("\nResults:");
				Console.WriteLine("Subtracting 1 from " + userInput + " equals " + math.SubtractOne(userInput));
				Console.WriteLine("Adding 15 to " + userInput + " equals " + math.Addfifteen(userInput));
				Console.WriteLine("Multiplying " + userInput + " by 3 equals " + math.MutiplyXThree(userInput));
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Please type a whole number.");
				return;
			}

		}
	}
}

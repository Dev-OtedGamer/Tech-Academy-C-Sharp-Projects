using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodSubmissionAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			Math math = new Math();

			Console.WriteLine("Please enter a number.");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter a second number or press enter to skip.");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine($"Result = {math.Add2(num1)}");
			}
			else
			{
				int num2 = Convert.ToInt32(input);
				Console.WriteLine($"Result = {math.Add2(num1, num2)}");
			}
			Console.ReadLine();
		}

	}
}

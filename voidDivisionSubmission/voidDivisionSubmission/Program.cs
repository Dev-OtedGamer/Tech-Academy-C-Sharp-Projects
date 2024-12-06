using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidDivisionSubmission
{
	class Program
	{
		static void Main(string[] args)
		{
			Math math = new Math();
			
			Console.WriteLine("Please enter a number.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			math.divide2(userInput);

			Console.WriteLine("Please enter another number.");
			int userInput2 = Convert.ToInt32(Console.ReadLine());

			int addResult;
			int subResult;

			math.PramOutputs(userInput2, out addResult, out subResult);

			Console.WriteLine($"Adding 10 to {userInput2} equals {addResult}");
			Console.WriteLine($"Subtracting 1 from {userInput2} equals {subResult}");

			int sum1 = math.PramOutputs(10, 8, 3);
			Console.WriteLine($"10 * 8 / 3 = {sum1}");
			int sum2 = math.PramOutputs(10, 8, 3, 0);
			Console.WriteLine($"8 * 3 / 10 + 0 = {sum2}");

			int sum3 = Math.add15(3);
			Console.WriteLine($"Adding 15 to 3 = {sum3}");

			Console.ReadLine();
		}
	}
}

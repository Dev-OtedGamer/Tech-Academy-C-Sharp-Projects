using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodSubmission
{
	class Program
	{
		public static void Main(string[] args)
		{

			Math math = new Math();

			Console.WriteLine("Please enter a number");
			int userInput = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Adding 25 to {userInput} = {math.Add25(userInput)}");
		
			Console.WriteLine("Please enter a decimal number");
			decimal userInput2 = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine($"Multiplying {userInput2} by 2 = {math.Add25(userInput2)}");

			Console.WriteLine("Please add a string that represents an integer.");
			string userInput3 = Console.ReadLine();

			try
			{
	
				int result = math.Add25(userInput3);

				Console.WriteLine($"Converting '{userInput3}' to an integer and subtracting 1 = {result}");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();

		}	

		
	}
}
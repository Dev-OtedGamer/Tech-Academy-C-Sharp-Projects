using System;
using System.Linq.Expressions;

class Program
{

	static void Main(string[] args)
	{

		List<int> numbers = new List<int> { 10, 15, 20, 25, 30 };

			try
			{
				Console.WriteLine("Pick a number.");
				int numberOne = Convert.ToInt32(Console.ReadLine());

				foreach (int number in numbers)
				{
					Console.WriteLine(number + " divided by " + numberOne + " = " + number / numberOne);

				}
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Please don't divide by zero");
			}
			catch (FormatException)
			{
				Console.WriteLine("Please type a whole number");
			}
			catch (Exception ex)
			{
				Console.WriteLine("An unexpected error occurred: " + ex.Message);
			}
			finally
			{
				Console.WriteLine("Exited the try/catch block. Program execution continues...");
			}

		Console.ReadLine();
	}
}

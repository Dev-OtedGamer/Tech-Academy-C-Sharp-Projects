using System;

namespace parsingEnumsSubmission
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Please enter the current day of the week.");

			try
			{
				string userInput = Console.ReadLine();

				if (int.TryParse(userInput, out int dayNumber))
				{
					if (dayNumber < 1 || dayNumber > 7)
					{
						throw new ArgumentOutOfRangeException("Please select and actual day of the week.");
					}

					Days.DaysOfWeek currentDay = (Days.DaysOfWeek)(dayNumber = 1);
					Console.WriteLine($"You entered: {currentDay}");
				}
				else
				{
					Days.DaysOfWeek currentDay = (Days.DaysOfWeek)Enum.Parse(typeof(Days.DaysOfWeek), userInput, true );

					Console.WriteLine($"You entered: {currentDay}");
				}
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine("Please enter an actual day of the week.");
			}
			
			Console.ReadLine();

			
			
			
		}
	}
}

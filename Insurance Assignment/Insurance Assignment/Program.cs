using System;

namespace CarInsuranceApproval
{
	class Program
	{
		static void Main(string[] args)
		{

			int age;
			bool hasDUI;
			int speedingTickets;


			// Ask for the applicants age, and checks for validation.
			while (true)
			{
				Console.WriteLine("What is your age?");
				if (int.TryParse(Console.ReadLine(), out age) && age > 0)
				{
					break;
				}
				else
				{
					Console.WriteLine("Please enter a valid age greater than 0.");
				}
			}

			// Ask if the applicant has ever had a DUI, and checks for validation.
			while (true)
			{
				Console.WriteLine("Have you ever had a DUI? (true/false)");
				if (bool.TryParse(Console.ReadLine(), out hasDUI))
				{
					break;
				}
				else
				{
					Console.WriteLine("Please enter 'true' or 'false'.");
				}
			}

			// Ask the number of speeding tickets the applicant has, and checks for validation.
			while (true)
			{
				Console.WriteLine("How many speeding tickets do you have?");
				if (int.TryParse(Console.ReadLine(), out speedingTickets) && speedingTickets >= 0)
				{
					break;
				}
				else
				{
					Console.WriteLine("Please enter a valid number of speeding tickets (0 or more).");
				}
			}

			// Determine if the applicant qualifies for car insurance
			bool isQualified = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

			// Print the qualification result
			Console.WriteLine("Qualified?");
			Console.WriteLine(isQualified);

			// Keep the console window open
			Console.ReadLine();
		}
	}
}

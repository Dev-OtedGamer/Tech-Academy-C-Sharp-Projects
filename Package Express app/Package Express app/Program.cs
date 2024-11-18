using System;

class Program
{
	static void Main()
	{
		//This line displays welcome message
		Console.WriteLine("Welcome to Package Express. Please Follow the istructions below.");

		//This line gets the package weight input from user
		Console.Write("Please enter the package weight: ");

		//Here we use TryParse to convert a sting to a double and check if the input is a valid number
		if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
		{
			Console.WriteLine("Invalid input. Please enter a positive number for the weight.");

			//This line stops the program from continuing if the input is not valid
			return;
		}
		//Checks if package is to heavy to ship with Package Express
		if (weight > 50)
		{
			//This line displays an error message if the package is to heavy
			Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");

			//This line stops the program from continuing if the package is to heavy
			return;
		}

		//This line gets the package width input from user
		Console.Write("Please enter the package width: ");

		//Here we use TryParse to convert a sting to a double and check if the input is a valid number
		if (!double.TryParse(Console.ReadLine(), out double width) || width <= 0)
		{
			Console.WriteLine("Invalid input. Please enter a positive number for the width.");

			//This line stops the program from continuing if the input is not valid
			return;
		}

		//This line gets the package height input from user
		Console.Write("Please enter the package height: ");

		//Here we use TryParse to convert a sting to a double and check if the input is a valid number
		if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
		{
			Console.WriteLine("Invalid input. Please enter a positive number for the height.");

			//This line stops the program from continuing if the input is not valid
			return;
		}

		//This line gets the package length input from user
		Console.Write("Please enter the package length: ");

		//Here we use TryParse to check if the input is a valid number
		if (!double.TryParse(Console.ReadLine(), out double length) || length <= 0)
		{
			Console.WriteLine("Invalid input. Please enter a positive number for the length.");

			//This line stops the program from continuing if the input is not valid
			return;
		}

		//Here we Calculate the total dimensions (width + height + length)
		double totalDimensions = width + height + length;
		if (totalDimensions > 50)
		{
			//This line displays an error message if the package is to big
			Console.WriteLine("Package is too big to be shipped via Package Express.");

			//This line stops the program from continuing if the package is to big
			return;
		}

		//This next part calculates the shipping cost

		//This line calculates the volume of the package
		double volume = width * height * length;

		//This line calculates the final shipping quote
		double quote = (volume * weight) / 100;

		//This part displays the shipping quote
		Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
		Console.WriteLine("Thank you!");






	}
}

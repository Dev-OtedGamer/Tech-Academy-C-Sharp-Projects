using System;
using System.Collections.Generic;


class Program
{
	static void Main()
	{
		//One-dimensional array of strings
		string[] animals = { "Fox", "Chicken", "Mosse", "Badger", "Mongoose", "Otter" };

		//One-dimensional array of integers
		int[] animalNum = { 3, 6, 9, 12 };

		//List of strings
		List<string> areaList = new List<string>();
		areaList.Add("Beach");
		areaList.Add("Mountians");
		areaList.Add("Desert");
		areaList.Add("Forest");
		areaList.Add("Jungle");


		Console.WriteLine("Welcome to the Animal Combat Selector!");

		int animalIndex;
		while (true)
		{
			Console.WriteLine("Please select a number from (0 - 5) to see what animal you will be facing in combat.");

			//Asks user to select an index from the one-dimensional array of strings
			Console.Write("Enter a number (0 - 5) ");
			string animalInput = Console.ReadLine();

			if (int.TryParse(animalInput, out animalIndex) && animalIndex >= 0 && animalIndex < animals.Length)
			{
				//Displays the index from the one-dimensional array of strings
				Console.WriteLine("The animal you will be facing in combat is a " + animals[animalIndex]);
				break;
			}
			else
			{
				//Displays a message when the index from the one-dimensional array of strings does not exist
				Console.WriteLine("Invalid selection please enter a number between (0 - 5)");
			}
		}


		int numIndex;
		while (true)
		{
			Console.WriteLine("\nNow lets see how many " + animals[animalIndex] + "s you will be facing in combat.");

			//Asks user to select an index from the one-dimensional array of integers
			Console.Write("Please select a number from (0 - 3) ");
			string animalNumInput = Console.ReadLine();

			if (int.TryParse(animalNumInput, out numIndex) && numIndex >= 0 && numIndex <= animalNum.Length)
			{
				//Displays the index from the one-dimensional array of integers
				Console.WriteLine("You will be facing " + animalNum[numIndex] + " " + animals[animalIndex] + "s .");
				break;
			}
			else
			{
				//Displays a message when the index from the one-dimensional array of integers does not exist
				Console.WriteLine("Invalid selection please enter a number between (0 - 3)");
			}
		}


		int areaIndex;
		while (true)
		{
			Console.WriteLine("Now lets see where you will be facing these " + animals[animalIndex] + "s .");

			//Asks user to select an index from the list of strings
			Console.Write("Please select a number from (0 - 4) ");
			string areaListInput = Console.ReadLine();


			if (int.TryParse(areaListInput, out areaIndex) && areaIndex >= 0 && areaIndex < areaList.Count)
			{
				//Displays the index from the list of strings
				Console.WriteLine("You will be facing " + animalNum[numIndex] + " " + animals[animalIndex] + "s at the " + areaList[areaIndex]);
				break;
			}
			else
			{
				//Displays a message when the index from the list of strings does not exist
				Console.WriteLine("Invalid selection please enter a number between (0 - 4)");
			}
		}

		Console.WriteLine("\nGood luck with your combat!");


	}
}

using System;

class Program
{

	static void Main()
	{
		//Welcome message for the game
		Console.WriteLine("Welcome to the Path and Door Adventure Game!");
		//Variable to control main game loop
		bool playGame;

		do
		{
			//Intro and listing the main path choices to the player
			Console.WriteLine("\nYou have woken up on a beach in a strange land with no idea of how you got there.");
			Console.WriteLine("You think to your self, how did I get here as you look around");
			Console.WriteLine("You see a path in front of you that forks in three directions");
			Console.WriteLine("1. The Forest Path");
			Console.WriteLine("2. The Mountain Path");
			Console.WriteLine("3. The Desert Path");
			Console.WriteLine("You must now choose a path to take");

			//Variable to store the players path choice
			int pathChoice;
			//Validation loop for the path choice
			while (true)
			{
				//Asking the player to choose a path
				Console.Write("Enter the number of your choice (1-3):");
				//TryParse input and checking for valid range
				if (int.TryParse(Console.ReadLine(), out pathChoice) && pathChoice >= 1 && pathChoice <= 3)
				{
					//Exits loop if input is valid
					break;
				}
				else
				{
					//Gives error message if input is not valid
					Console.WriteLine("Invalid input. Please select a valid path.");
				}
			}
			//Displays player choice and moves on to door selection
			Console.WriteLine($"\nYou chose Path {pathChoice}. Now select a door to enter:");

			//Lists the door choices
			Console.WriteLine("1. The Ruby Door");
			Console.WriteLine("2. The Turquoise Door");
			Console.WriteLine("3. The Jade Door");
			Console.WriteLine("4. The Gold Door");

			//Variable to store the players door choice
			int doorChoice;
			//Validation loop for door choice
			while (true)
			{
				//Asking the player to choose a door
				Console.Write("Enter the number of your choice (1-4): ");
				//TryParse input and checking for valid range
				if (int.TryParse(Console.ReadLine(), out doorChoice) && doorChoice >= 1 && doorChoice <= 4)
				{
					//Exit the loop if input is valid
					break;
				}
				else
				{
					//Gives error message if input is not valid
					Console.WriteLine("Invalid input. Please select a valid door.");
				}
			}

			//Displays the player choice and moves on to outcome
			Console.WriteLine($"\nYou chose Door {doorChoice}. Let's see what happens...");

			//Switch statement  to provide different outcomes based on players chocies
			switch (pathChoice)
			{
				case 1://Forest Path choice
					switch (doorChoice)
					{
						//Ruby door choice
						case 1:
							Console.WriteLine("You found a treasure chest filled with gold in the forest!");
							break;
						//Turquoise door choice
						case 2:
							Console.WriteLine("A friendly elf offers you magical potions.");
							break;
						//Jade door choice
						case 3:
							Console.WriteLine("A hidden trapdoor leads you to an underground cave, where you encounter a dragon who ends your adventure");
							break;
						//Gold door choice
						case 4:
							Console.WriteLine("You encounter a wise owl who shares ancient secrets.");
							break;
					}
					break;

				case 2://Mountain Path choice
					switch (doorChoice)
					{
						//Ruby door choice
						case 1:
							Console.WriteLine("You discover a stunning mountain vista, unfortunately you got to close to the edge and have fallen. Your adventure ends here.");
							break;
						//Turquoise door choice
						case 2:
							Console.WriteLine("A group of mountain goats guide you to safety.");
							break;
						//Jade door choice
						case 3:
							Console.WriteLine("You find a mysterious map carved into the rock.");
							break;
						//Gold door choice
						case 4:
							Console.WriteLine("A sudden avalanche reveals a hidden tunnel!");
							break;
					}
					break;

				case 3: //Desert path choice
					switch (doorChoice)
					{
						//Ruby door choice
						case 1:
							Console.WriteLine("You discover a beautiful Oasis with water and fruit trees.");
							break;
						//Turquoise door choice
						case 2:
							Console.WriteLine("As you wanderd the desert for 3 days without finding any water. Your adventure ends here.");
							break;
						//Jade door choice
						case 3:
							Console.WriteLine("You stumble upon an ancient pyramid filled with treasure beyond your wildest imagination.");
							break;
						//Gold door choice
						case 4:
							Console.WriteLine("A traveling band of merchants agree to lead you to saftey.");
							break;
					}
					break;

				//Defualt statement if the switch validation is missed
				default:
					Console.WriteLine("Something unexpected happened. How curious!");
					break;
			}

			//Variable to store the replay decision
			string playAgainResponse;
			do
			{
				//Asks the player if they want to play again
				Console.Write("\nWould you like to play again? (yes/no): ");

				//Removes white space and converts to lower case if needed
				playAgainResponse = Console.ReadLine()?.Trim().ToLower();

				//Validation for "yes" or "no"
				if (playAgainResponse == "yes" || playAgainResponse == "no")
				{
					//Exits the loop if input is valid
					break;//Valid input, exit loop
				}
				else
				{
					//Gives error message if input is not valid
					Console.WriteLine("Please enter 'yes' or 'no'.");
				}
			
			} while (true);

			//Update game loop condition based on players choice
			playGame = playAgainResponse == "yes";

		//Repeat the game loop if the player wants to play again
		} while (playGame);

		//Goodbye message after the game ends
		Console.WriteLine("\nThanks for playing! Goodbye!");

	}
}

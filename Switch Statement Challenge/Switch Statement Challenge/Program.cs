
using System;

	class Program
	{

		static void Main(string[] args)
		{

			Console.WriteLine("Please choose a door number, the doors are numbered 1 - 4:");
			string usersInput = Console.ReadLine();

			//Try to convert the input to a number
			if (int.TryParse(usersInput, out int number))
			{
				switch (number)
				{

				case 1:
					Console.WriteLine("Behind the door you find a hungry dog, it immediately attacks you and mortally wounds you. Your journey ends here...");
					break;

				case 2:
					Console.WriteLine("Behind the door you find a long dark hallway, you can see light coming from the other end of the long hallway. You may continue on your journey...");
					break;

				case 3:
					Console.WriteLine("As you step through the door, the floor gives way at your feet plunging you down some 60 feet to your death. Your journey ends here...");
					break;

				case 4:
					Console.WriteLine("Stepping through the door you see a dark shadowy figure, before you can react the figure plunges a sword deep into your heart and killing you. Your journey ends here...");
					break;

				default:
					Console.WriteLine("Invalid choice. Please choose a number between 1 and 4");
					break;

				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a number.");
			}

		}
	}
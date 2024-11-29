using System;

class Program
{
	static void Main(string[] args)
	{
		// Part 1:
		// One-dimensional array of strings (I choose to use flowers)
		string[] flowers = { "Rose", "Daisy", "Pansy", "Orchid", "Sunflower", "Tulip", "Lotus" };

		// Display the array of strings to the user on separate lines
		Console.WriteLine("We have the following Flowers: ");
		foreach (string flower in flowers)
		{   
			Console.WriteLine("- " + flower); 
		}

		//Asks the user to add some text that helps describe flowers
		Console.WriteLine("\nPlease add some text to help describe flowers or how they make you feel.");
		string userInput = Console.ReadLine();

		//Adds the user input to each of strings in the array
		for (int i = 0; i < flowers.Length; i++)
		{
			flowers[i] += "s " + userInput;
		}

		//Displays the users text at the end of each string
		Console.WriteLine("\nHere are the updated flower descriptions:");
		foreach(string flower in flowers)
		{
			Console.WriteLine(flower);
		}

//______________________________________________________________
		//Part 2: Infinite loop
		

		//Added a counter variable to fix the infinite loop to only play the loop and break after counting to 5
		int counter = 0;

		//Creates the infinte loop
		while (true)
		{
			//Displays a message for the infinte loop
			Console.WriteLine("\nWith out a break condition added this will continue to play over and over.");

			//Adds 1 to the counter every time it displays
			counter++;

			//The break condition stops the loop after 5 times
			if (counter >= 5)
			{
				//Displays a message about exiting the loop
				Console.WriteLine("The loop has completed 5 times and will now exit.\n");

				//Ends the loop
				break;
			}
		}
//________________________________________________________________________
		//Part 3:
		
		//New one-dimensional array of strings (I choose to use food)
		string[] dinner = { "Turkey", "Mashed Potatoes & Gravy", "Stuffing", "Green Beans", "Fruit Salad", "Candied Yams", "Pumkin Pie" };
			
		//Used the "<" operator to iterate through the loop
		for (int plated = 0; plated < dinner.Length; plated++)
		{	
			if (dinner[plated] == "Pumkin Pie")
			Console.WriteLine(dinner[plated]);
				
		}

		//used the "<=" operator to iterate through the loop
		for (int plated = 0; plated <= dinner.Length - 1; plated++)
		{
			if (dinner[plated] == "Candied Yams")
			Console.WriteLine(dinner[plated] + " are some of my favorite parts of Thanksgiving.");
		}

//______________________________________________________________________
		//Part 4:
		//List of unique items (I choose to make this part a NPC shop)
		List<string> shopItems = new List<string> {"Potion", "Food", "Arrows", "Sword", "Axe", "Armor", "Runes"};

		//Welcome To the shop message
		Console.WriteLine("\nWelcome to Sam's shop! I am currently selling these items: ");

		//Displays the items in shop
		foreach (string goods in shopItems) 
		{
			Console.WriteLine("- " + goods);
		}

		//Asks the user to input text to search for an item name in the list
		Console.WriteLine("\nPlease enter the name of item you would like to look at.");
		string shopInput = Console.ReadLine();

		//Adds a varible for tracking if a match is found
		bool itemFound = false;

		//Adds while loop till user inputs an item in the list
		while (!itemFound)
		{
			//Loop that iterates through the list
			for (int shopList = 0; shopList < shopItems.Count; shopList++)
			{
				//Validation for the user input that ignores case-sensitive
				if (shopItems[shopList].Equals(shopInput, StringComparison.OrdinalIgnoreCase))
				{
					// displays the index of the list item that contains matching text on the screen
					Console.WriteLine($"Item found! '{shopInput}' it is located on shelf {shopList} behind me. Let me grab that for you.");
					//Stops the loop if match is found
					itemFound = true;
					break;
				}
			}

			// If not in list
			if (!itemFound)
			{
				//Tells the user if the text they input is not in the list
				Console.WriteLine($"Sorry, the item '{shopInput}' is not availble in this shop.");
				shopInput = Console.ReadLine();
			}
		}
		//Message to thank the player for shopping
		Console.WriteLine("\nThanks for visiting Sam's shop!");

//________________________________________________________________________________
		//Part 5:
		//List of strings that has at least two identical strings in the list.
		List<string> leeShopItems = new List<string> { "Helmet", "Shield", "Bolts", "Helmet", "Boots", "Shield", "Boots", "Leg Armor" };

		//Welcome To the shop message
		Console.WriteLine("\nWelcome to Lee's shop! I am currently having a sale on many items, as I have duplicates of those items: ");

		//Displays the items in shop
		foreach (string leeGoods in leeShopItems)
		{
			Console.WriteLine("- " + leeGoods);
		}

		// Ask the user to input text to search for an item name in the list
		Console.WriteLine("\nPlease enter the name of the item you would like to look at.");
		string leeShopInput = Console.ReadLine();

		// Variable for tracking if a match is found
		bool leeItemFound = false;

		//While loop to keep running until a match is found
		while (!leeItemFound)
		{
			// Loop that iterates through the list and displays the indices of the list that contain matching text on the screen
			for (int leeShopList = 0; leeShopList < leeShopItems.Count; leeShopList++)
			{
				// Check if the user's input matches an item in the list and validation for ignoring case sensitive
				if (leeShopItems[leeShopList].Equals(leeShopInput, StringComparison.OrdinalIgnoreCase))
				{
					// Display the index of the matching item
					Console.WriteLine($"Item found! '{leeShopInput}' is located on shelf {leeShopList}. Let me grab that for you.");
					leeItemFound = true;
				}
			}

			// Tells userr if they put in text that isn't in the list
			if (!leeItemFound)
			{
				Console.WriteLine($"Sorry, the item '{leeShopInput}' is not available in this shop. Please try again:");
				leeShopInput = Console.ReadLine();
			}
		}

		// Thank the user for shopping
		Console.WriteLine("\nThanks for visiting Lee's shop!");


//_________________________________________________________________________________________________
		//Part 6:
		//List of strings that has at least two identical strings in the list.
		List<string> frankShopItems = new List<string>
		{
			"Mushroom", "Scroll", "Elixer", "Soup", "Scroll", "Mushroom", "Soup", "Robe"
		};

		//Welcome To the shop message
		Console.WriteLine("\nWelcome to Frank's Shop! Here is my current stock with duplicates:");

		//Creats a new list to keep track of duplicates
		List<string> seenItems = new List<string>();

		//foreach loop that evaluates each item in the list and displays a message showing the string and whether or not it has already appered in the list.
		foreach (string frankItem in frankShopItems)
		{
			if (seenItems.Contains(frankItem))
			{
				Console.WriteLine($"- {frankItem}: This has already appeared in the list.");
			}
			else
			{
				Console.WriteLine($"- {frankItem}: This is the first time this item is appearing.");
				seenItems.Add(frankItem);
			}	
		}
		//Thanks for visiting message
		Console.WriteLine("\nThanks for visiting Frank's shop!");
		Console.ReadLine();


	}
}

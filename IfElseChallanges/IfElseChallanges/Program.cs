using System;

class Program
{ 
	static void Main()
	{ 
		//In a "If" statment it will always evaluate what ever is in the parentheses immediatly after it as a true or false question.
		if (true)
		{
			Console.WriteLine("Hello, World!");	
		}

		//Here is how to write else statements
		//== is a Comparison operator and returns a true / false answer to the question: Is the value on the right equal to the value on the left.
		if (2 == 2)
		{
			Console.WriteLine("2 equals 2!");
		}
		else
		{
			Console.WriteLine("2 dose not equal 2");
		}

		//Here is another example of an else statment
		string name = "Brett";

		if (name == "Jesse")
		{
			Console.WriteLine("Your name is Jesse");
		}
		else
		{
			Console.WriteLine("Your name is not Jesse");
		}

		//Here is another example, you can use as many esle if statements as you need.
		String name2 = "Adam";

		if (name2 == "Jesse")
		{
			Console.WriteLine("Your name is Jesse");
		}
		else if (name2 == "Brett")
		{
			Console.WriteLine("Your name is not Jesse");
		}
		else
		{
			Console.WriteLine("Your name is not Jesse. Your name is not Brett.");
		}

		//Here is how to check for several conditions:
		string name3 = "Erik";

		if (name3 == "Jesse")
		{
			Console.WriteLine("Your name is Jesse");
		}
		else if (name3 == "Brett")
		{
			Console.WriteLine("Your name is not Jesse");
		}
		else if (name3 == "Adam")
		{
			Console.WriteLine("Your name is Adam");
		}

		//Once one of the expressions inside the parentheses evaluates to true, then the rest are skipped.
		//Here we added the else statment so this bit of code would print somting to the console
		else
		{
			Console.WriteLine("your name is not jesse, or brett, or adam");
		}

		string name4 = "Adam";

		if (name4 == "Jesse")
		{
			Console.WriteLine("Your name is Jesse");
		}
		if (name4 == "Brett")
		{
			Console.WriteLine("Your name is not Jesse");
		}
		if (name4 == "Adam")
		{
			Console.WriteLine("Your name is Adam");
		}

		//The != operator means "does not equal"
		string name5 = "Adam";

		if (name5 != "Jesse")
		{
			Console.WriteLine("Your name is not Jesse");
		}

		if (1 != 2)
		{
			Console.WriteLine("All is right with the universe.");
		}
		else
		{
			Console.WriteLine("We live in a bizarro world.");
		}

		//If, else if and else staements challange
		if (7 * 2 == 7 + 7)
		{
			Console.WriteLine("7 x 2 is equal to 7 + 7");
		}
		else if (7 * 2 != 7 + 7)
		{
			Console.WriteLine("7 x 2 is not equal to 7 + 7");
		}
		else
		{
			Console.WriteLine("We must not understand math well");
		}

		//Here is how to use the greater than (>) operator (Remember the aligator mouth always eats the larger number)
		int num1 = 12;
		int num2 = 14;
		if (num1 > num2)
		{
			Console.WriteLine("The first number is larger.");
		}
		else
		{
			Console.WriteLine("The second number is larger");
		}

		//Lesser than is written as follows
		int age = 19;

		if (age < 21)
		{
			Console.WriteLine("No, you may not purchase that bottle of wine.");
		}
		else
		{
			Console.WriteLine("That will be $23.71");
		}

		//The lesser than or equal to operator is written as follows:
		int age2 = 20;

		if (age2 <= 20)
		{
			Console.WriteLine("No you may not purchase that bottle of wine.");
		}
		else
		{
			Console.WriteLine("There you go!");
		}

		//Greater than or equal to is written as follows:
		int age3 = 20;

		if (age3 >= 25)
		{
			Console.WriteLine("Yes you may rent a car from us.");
		}
		else
		{
			Console.WriteLine("No you may not rent a car from us.");
		}

		//Console output Challenge
		int age4 = 700;

		if (age4 > 500)
		{
			Console.WriteLine("Yes 700 is greater then 500.");
		}
		else
		{
			Console.WriteLine("Something must have gone wrong.");
		}

		int age5 = 50;

		if (age5 <= 60)
		{
			Console.WriteLine("50 is less then 60.");
		}
		else
		{
			Console.WriteLine("Something must have gone wrong.");
		}
		

		//The expressions before and after the AND operator both have to be true for the code in the curly braces to run:
		int num3 = 7;
		int num4 = 18;
		int num5 = 12;
		if (num4 > num3 && num5 < num4)
		{
			Console.WriteLine("The second number is larger then the others.");
		}

		//When using the AND operator, for the statement inside the parentheses to evaluate to true, each expression on the left and right of it must be true:
		int num6 = 7;
		if (true && true && true && true && num6 == 20)
		{
			Console.WriteLine("Everything was true!");
		}
		else
		{
			Console.WriteLine("There was a false somewhere!");
		}
		

		//Let’s see a real-life example:
		int packageWeight = 50;
		int packageLength = 25;
		if (packageWeight > 40 && packageLength > 20)
		{
			Console.WriteLine("This package is to big to ship.");
		}
		else
		{
			Console.WriteLine("Something must have gone wrong.");
		}

		// "||" is how you write OR Oprator
		int num7 = 7;
		if (num7 < 7 || num7 == 12)
		{
			Console.WriteLine("At least one value is true.");
		}

		if (num7 == 12 || num7 == 18)
		{
			Console.WriteLine("At least one value is true.");
		}
		else
		{
			Console.WriteLine("No value is true.");
		}

		if (num7 == 12 || num7 == 18 || num7 == 20 || num7 == 7)
		{
			Console.WriteLine("Something is true.");
		}

		//Real life scenario:
		string role = "admin";
		if (role == "admin" || role == "administrator")
		{
			Console.WriteLine("You may have access to the entire software system.");
		}

		//Here is another example:
		int num8 = 7;
		if (num8 < 18 && ((num8 == 7) ||num8 == 2) && ((num8 == 8 && num8 > 20) || (num8 < 20 && num8 > 2)))
		{
			Console.WriteLine("Wow, that was confusing.");
		}

		// Ternary operator is "?" and the meaning is: made up of three parts.
		// For example:
		int num9 = 7;
		int num10 = 12;

		string result = num9 > num10 ? "num9 is greater than num10" : "num9 is not greater than num10";
		Console.WriteLine(result);

		//Ternary operator challenge
		int num11 = 15;
		int num12 = 4;

		string result1 = num11 > num12 ? "num12 is not greater than num11" : "num12 is greater than num11";
		Console.WriteLine(result1);

		Console.ReadLine();

	}
}


using structChallenge;
using System;

namespace structChallenge
{ 

	class Program 
	{ 
		static void Main(string[] args)
		{
			Number number = new Number();

			number.Amount = 1.5m;

			Console.WriteLine($"Amount is: {number.Amount}");

			Console.ReadLine();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeSubmission
{
	class Program
	{
		static void Main(string[] args)
		{
			//Prints the current date and time to console
			Console.WriteLine("Current Date and Time: " + DateTime.Now);

			//Asks the user for a number
			Console.WriteLine("Please enter a number for the hours you would like to add: ");
			string userNumb = Console.ReadLine();

			int hours;
			if (int.TryParse(userNumb, out hours))
			{
				//Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2
				DateTime dateTime = DateTime.Now.AddHours(hours);
				Console.WriteLine("In " + hours + " hours the time will be: " + dateTime);
			}
            else
            {
                Console.WriteLine("That was not a valid number, Please try agian later. Bye for Now");
            }
        }
	}
}

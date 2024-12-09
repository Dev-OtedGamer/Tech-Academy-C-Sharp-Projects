using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametersSubmission
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee<string> Things = new Employee<string>()
			{
				things = new List<string> { "Stapler", "Pens", "Notepad", "paperclips" }
			};

			Employee<int> Things2 = new Employee<int>()
			{
				things = new List<int> { 1, 4, 2, 50 }
			};

			Console.WriteLine("List of employee things");
			foreach (string thing in Things.things)
			{ 
				Console.WriteLine(thing);
			}

			Console.WriteLine("Quanity of employee things");
			foreach (int thing in Things2.things)
			{
				Console.WriteLine(thing);
			}
			Console.ReadLine();

			
			
		}
	}
}

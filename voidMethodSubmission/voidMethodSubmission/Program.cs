using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethodSubmission
{
	class Program
	{
		static void Main(string[] args)
		{
			Math math = new Math();

			math.plusTen(7, 11);
			
			math.plusTen(num1: 1, num2: 2);

			Console.ReadLine();
		}
	}
}

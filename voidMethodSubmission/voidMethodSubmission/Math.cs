using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethodSubmission
{
	public class Math
	{
		public void plusTen(int num1, int num2)
		{
			int result = num1 + 10;

			Console.WriteLine($"The first number plus 10 equals {result}");
			Console.WriteLine($"The second number is {num2}");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidDivisionSubmission
{
	public class Math
	{
		public void divide2(int num1)
		{
			int result = num1 / 2;

			Console.WriteLine($"{num1} divided by 2 equals {result}");
		}

		public void PramOutputs(int num2, out int add10, out int sub1)
		{
			add10 = num2 + 10;
			sub1 = num2 - 1;
		}

		public int PramOutputs(int num1, int num2, int num3)
		{
			return num1 * num2 / num3;
		}
		public int PramOutputs(int num1, int num2, int num3, int num4)
		{
			return num2 * num3 / num1 + num4;
		}

		public static int add15(int num1)
		{
			return num1 + 15;
		}
	}
}

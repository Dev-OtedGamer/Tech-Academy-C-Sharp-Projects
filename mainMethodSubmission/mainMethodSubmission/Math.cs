using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodSubmission
{
	public class Math
	{
		public int Add25(int i)
		{
			return i + 25;
		}

		public int Add25(decimal i)
		{
			return (int)(i * 2);
		}

		public int Add25(string i)
		{
			if (int.TryParse(i, out int result))
			{
				return result - 1;
			}
			else
			{
				throw new ArgumentException("The Provided String is not a valid integer.");
			}

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorsOverloadSubmission
{
	class Program
	{
		static void Main(string[] args)
		{

			Employee employee1 = new Employee { EmpID = 1 };
			Employee employee2 = new Employee { EmpID = 2 };
			Employee employee3 = new Employee { EmpID = 1 };

			Console.WriteLine($"Comparing employee ID's ");
			Console.WriteLine("Is employee1 equal to employee2? " + (employee1 == employee2));
			Console.WriteLine("Is employee1 equal to employee3? " + (employee1 == employee3));
			Console.WriteLine("Is Employee1 not equal to employee2? " + (employee1 != employee2));

		}
	}
}

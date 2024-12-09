using polymorphismSubmission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubbmision
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			{
				employee.firstName = "Sample";
				employee.lastName = "Student";
			}

			IQuittable quittable = employee;

			quittable.Quit();

			Console.ReadLine();

		}
	}
}

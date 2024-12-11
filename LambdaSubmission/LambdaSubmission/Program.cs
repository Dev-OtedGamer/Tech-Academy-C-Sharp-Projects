using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
	class Program
	{
		static void Main(string[] args)
		{
			//Created a List with 10 employees each with a First & Last name and an ID two with first name "Joe"
			List<Employee> employees = new List<Employee>
			{
				new Employee { FirstName = "Joe", LastName = "Lee", EmpId = 1 },
				new Employee { FirstName = "Stan", LastName = "Lee", EmpId = 2 },
				new Employee { FirstName = "Sara", LastName = "Beth", EmpId = 3 },
				new Employee { FirstName = "Pamale", LastName = "Ray", EmpId = 4 },
				new Employee { FirstName = "Joe", LastName = "Smith", EmpId = 5 },
				new Employee { FirstName = "John", LastName = "Doe", EmpId = 6 },
				new Employee { FirstName = "Jane", LastName = "Doe", EmpId = 7 },
				new Employee { FirstName = "Bill", LastName = "Williams", EmpId = 8 },
				new Employee { FirstName = "Sam", LastName = "Forest", EmpId = 9 },
				new Employee { FirstName = "Elliott", LastName = "Gump", EmpId = 10 }
			};

			//Foreach loop to creat a new list with employees with first name "Joe"
			List<Employee> NameJoe = new List<Employee>();
			Console.WriteLine("Using foreach loop to display all Employees with first name'Joe'");
			foreach (Employee employee in employees)
			{
				if (employee.FirstName == "Joe")
				{
					NameJoe.Add(employee);
				}
			}
			//Displays NameJoe list
			foreach (Employee joe in NameJoe)
			{
				Console.WriteLine($"Employee Name: {joe.FirstName} {joe.LastName} Employee Id: {joe.EmpId} ");
			}
			Console.WriteLine($"\nUsing Lambda expresion to display all Employees with first name'Joe'");
			//Lambda expression to create a list of employyes with first name "Joe"
			List<Employee> nameJoe = employees.Where(x => x.FirstName == "Joe").ToList();
			//Displays nameJoe List created with Lambda
			foreach (Employee employee in nameJoe)
			{
				Console.WriteLine($"Employee Name: {employee.FirstName} {employee.LastName} Employee Id: {employee.EmpId}" );
			}
			Console.WriteLine($"\nUsing Lambda expression to display all employees with an Id above 5");
			//Lambda expression that displays all Employees with an Id number above 5
			List<Employee> IdAbove5 = employees.Where(x => x.EmpId > 5).ToList();
			foreach(Employee employee in IdAbove5)
			{
				Console.WriteLine($"Employee Name: {employee.FirstName} {employee.LastName} Employee Id: {employee.EmpId} ");

			}
		}
	}
}

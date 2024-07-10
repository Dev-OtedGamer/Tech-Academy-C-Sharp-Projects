using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 details
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            decimal hourlyRate1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week? ");
            int hoursPerWeek1 = int.Parse(Console.ReadLine());

            //Person 2 details
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            decimal hourlyRate2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week? ");
            int hoursPerWeek2 = int.Parse(Console.ReadLine());

            //Person 1 annual salary
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(annualSalary1);

            //Person 2 annual salary
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;
            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(annualSalary2);

            //Comparing the salaries
            bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does person 1 make more then person 2?");
            Console.WriteLine(doesPerson1MakeMore);
            Console.ReadLine();
        }
    }
}

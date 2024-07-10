using System;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 124;
            int num2 = 256;
            int total = num1 + num2;
            Console.WriteLine(total);

            int num3 = 78;
            int num4 = 360;
            int difference = num4 - num3;
            Console.WriteLine(difference);

            int num5 = 2;
            int num6 = 23;
            int product = num6 * num5;
            Console.WriteLine(product);

            int num7 = 56;
            int quotient = num7 / num5;
            Console.WriteLine(quotient);

            int remainder = num4 % num3;
            Console.WriteLine(remainder);

            int evenOrOdd = num6 % 2;
            Console.WriteLine(evenOrOdd);

            string firstName = "Josh";
            string lastName = "Rollins";
            string Name = firstName + " " + lastName;
            Console.WriteLine(Name);
        }
    }
}

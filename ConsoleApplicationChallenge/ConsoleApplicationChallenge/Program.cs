using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets do some math");
            Console.WriteLine("First Multiplication");
            long numberChoice;
            while (true)
            {
                Console.WriteLine("Choose a number.");
                if (long.TryParse(Console.ReadLine(), out numberChoice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
                long productResult = numberChoice * 50;
                Console.WriteLine(productResult);

            Console.WriteLine("Second lets do some addition.");
            long numberChoice2;
            while (true)
            {
                Console.WriteLine("Choose another number.");
                if (long.TryParse(Console.ReadLine(), out numberChoice2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

                long total = numberChoice2 + 25;
                Console.WriteLine(total);

            Console.WriteLine("Now lets do some division.");
            long numberChoice3;
            while (true)
            {
                Console.WriteLine("Choose another number.");
                if (long.TryParse(Console.ReadLine(), out numberChoice3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

                decimal quotient = numberChoice3 / 12.5m;
                Console.WriteLine(quotient);
                

            Console.WriteLine("Lets move on to Boolean");
            long numberChoice4;
            while (true)
            {
                Console.WriteLine("Choose another number.");
                if (long.TryParse(Console.ReadLine(), out numberChoice4))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

                bool greaterThen = numberChoice4 < 50;
                Console.WriteLine(greaterThen);

            Console.WriteLine("Now lets look at Remainders.");
            long numberChoice5;
            while (true)
            {
                Console.WriteLine("Choose another number.");
                if (long.TryParse(Console.ReadLine(), out numberChoice5))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            long remainder = numberChoice5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}

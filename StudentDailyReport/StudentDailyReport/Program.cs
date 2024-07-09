using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Input name
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            //Input course
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            //Input Page number, w/ validation
            int pageNumber;
            while (true)
            {
                Console.WriteLine("What page are you on?");
                if (int.TryParse(Console.ReadLine(), out pageNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid page number.");
                }
            }

            //Input help needed, w/ validation
            bool needsHelp;
            while (true)
            {
                Console.WriteLine("Do you need help with anything? (Please answer \"true\" or \"false\".)");
                if (bool.TryParse(Console.ReadLine(), out needsHelp))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 'true' or 'false'.");
                }
            }

            //Input Positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? (Please give specifics.) ");
            string positiveExperiences = Console.ReadLine();

            //Input additional feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? (Please be specific)");
            string additionalFeedback = Console.ReadLine();

            //Input study hours, w/ validation
            double studyHours;
            while (true)
            { 
                Console.WriteLine("How many hours did you study today?");
                if (double.TryParse(Console.ReadLine(), out studyHours))
                { 
                    break; 
                }
                else
                {
                    Console.WriteLine("Please enter  a valid number of hours.");
                }
            }
            //Thank you message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
     }
}

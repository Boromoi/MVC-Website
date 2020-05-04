using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        /// <summary>
        /// App.exe 7:03 15:53
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {          
            var book = new Book("Liam's Grade Book");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                
                if(input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average is {stats:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}

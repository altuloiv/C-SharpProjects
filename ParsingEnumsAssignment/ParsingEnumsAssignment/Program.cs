using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wenesday,
            Thursday,
            Friday,
            Saturday
        }
        static public DaysOfWeek daysOfWeek;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week and press enter.");
            bool userInput = false;
            while (!userInput)
            {
                try
                {
                    string input = Console.ReadLine().ToLower();
                    input = input.First().ToString().ToUpper() + input.Substring(1);
                    if (Enum.TryParse<DaysOfWeek>(input, out daysOfWeek))
                    {
                        Console.WriteLine("You picked " + daysOfWeek);
                        userInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Error " + input + " not found. Please enter a correct day of the week.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}

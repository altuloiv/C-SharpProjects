using System;
using System.Collections.Generic;

namespace StringAndIntegerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of integers for division
            List<int> numList = new List<int>();
            numList.Add(10);
            numList.Add(12);
            numList.Add(17);
            numList.Add(32);
            numList.Add(20);
            numList.Add(14);
            numList.Add(2);

            Console.WriteLine("Choose a number. This number will divide each number in the list.");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide the two numbers");
                foreach(int i in numList)
                {
                    Console.WriteLine("{0} / {1} = {2}", i, userInput, i / userInput);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can not be divided by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please use a whole number.");
            }
            finally
            {
                Console.WriteLine("Task Completed.");
            }
            Console.ReadLine();
        }
    }
}

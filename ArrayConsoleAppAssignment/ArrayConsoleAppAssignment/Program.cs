using System;
using System.Collections.Generic;

namespace ArrayConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] infoArray1 = new string[] { "Albert Tulo", "Chicago", "Software Developer" };

            Console.WriteLine("Enter \"0\" to display Name.\nEnter \"1\" to display City.\nEnter \"2\" to display Occupation.");
            int list1 = Convert.ToInt32(Console.ReadLine());

            switch (list1)
            {
                case 0:
                    Console.WriteLine("The applicant's name is: " + infoArray1[list1]);
                    break;
                case 1:
                    Console.WriteLine("The applicant's city is: " + infoArray1[list1]);
                    break;
                case 2:
                    Console.WriteLine("The applicant's ocupation is: " + infoArray1[list1]);
                    break;
                default:
                    Console.WriteLine("Index Error please resubmit.");
                    break;

            }
            Console.ReadLine();

            //Array of integer
            int[] intArray = new int[] { 12, 53, 22 };

            Console.WriteLine("How many eggs are in a dozen? Enter \"0\" for the info.\nWhat was Albert's Favorite Football Number? Enter \"1\" to find out.\nWhat was Albert's Favorite Birthday? Enter\"2\" to find out.");
            int indexArray = int.Parse(Console.ReadLine());

            switch(indexArray)
            {
                case 0:
                    Console.WriteLine("There are " + intArray[indexArray] + " eggs in a dozen eggs.");
                    break;
                case 1:
                    Console.WriteLine("Albert's Favorite Football Number is " + intArray[indexArray]);
                    break;
                case 2:
                    Console.WriteLine("Albert's Favorite Birthday was his " + intArray[indexArray] + "nd Birthday!");
                    break;
                default:
                    Console.WriteLine("Index Error please resubmit.");
                    break;
            }
            Console.ReadLine();

            //list of strings and instantiates the list.
            List<string> intList = new List<string>();
            intList.Add("Tomato");
            intList.Add("Potato");
            intList.Add("Carrot");
            intList.Add("Apple");
            intList.Remove("Apple");

            Console.WriteLine("Enter an index of \"0\", \"1\", or \"2\".");
            int intList1 = Convert.ToInt32(Console.ReadLine());

            switch (intList1)
            {
                case 0:
                    Console.WriteLine(intList[intList1] + " is a vegtable");
                    break;
                case 1:
                    Console.WriteLine(intList[intList1] + " is a vegtable.");
                    break;
                case 2:
                    Console.WriteLine(intList[intList1] + " is a vegtable.");
                    break;
                default:
                    Console.WriteLine("Index has no information.");
                    break;
            }
            Console.ReadLine();

        }
    }
}

using System;

namespace CarInsuranceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //start of app
            Console.WriteLine("Welcome To the Car Insurance Qaulifier!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();

            //asking for age setting variable
            Console.WriteLine("What is your age?");
            int AgeOfUser = Convert.ToInt32(Console.ReadLine());

            //asking question for dui setting boolean value for duis for later use. 
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("If you have, respond with \"True\", otherwise respond with \"False\".");
            Console.WriteLine("Please respone with \"true\" or \"false\": ");
            bool DUIs = bool.Parse(Console.ReadLine());

            //asking for number of tickets and setting variable tickets for later use
            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());

            //checking to see if we qualify by ensuring the user is above the age of 15, has less than 3 tickets AND does not have any duis
            Console.WriteLine("Do you qualify?\"If  you do qualify, the result will display true, \"if you do not qualify, it will display false.");
            Console.WriteLine(AgeOfUser > 15 && Tickets < 3 && DUIs == false);

            Console.ReadLine();
            
        }
    }
}

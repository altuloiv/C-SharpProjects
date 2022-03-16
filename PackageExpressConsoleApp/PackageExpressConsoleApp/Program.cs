using System;

namespace PackageExpressConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.\nPres enter to continue.");
            Console.ReadLine();

            Console.WriteLine("What is the package weight?");
            string pakWeight = Console.ReadLine();
            float floatWeight = float.Parse(pakWeight);

            string weightResult = floatWeight > 50 ? "ERROR: Package is too heavy to be shipped via Package Express. Have a good Day" : "Please enter the package width.";
            Console.WriteLine(weightResult);

            string pakWidth = Console.ReadLine();
            float floatWidth = float.Parse(pakWidth);

            Console.WriteLine("Please enter package height.");
            string pakHeight = Console.ReadLine();
            float floatHeight = float.Parse(pakHeight);

            Console.WriteLine("Please enter package length.");
            string pakLength = Console.ReadLine();
            float floatLength = float.Parse(pakLength);


            float totalDimension = floatWidth + floatHeight + floatLength;
            if (totalDimension > 50)
            {
                Console.WriteLine("ERROR: Package is too big to be shipped via Package Express. Have a good day!");
            }

            else
            {
                float pakQuote = (floatWidth * floatHeight * floatLength) * floatWeight / 100;
                float finalQuote = (float)Math.Round(pakQuote, 2);
                Console.WriteLine("The quoted cost to ship your package is: $" + finalQuote + " Have a good day!");
            }
            Console.ReadLine();

        }
    }
}

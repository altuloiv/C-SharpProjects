using System;

namespace CallingMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking for anumber and storing it to a variable
            Console.WriteLine("What number would you like to calculate?\n Please enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adding 30 to " + number);

            //creating new object of Sub class and names it as Object
            Sub Object = new Sub();
            //access the sub class method of SubIt
            int returnX = Object.AddIt(number);
            Console.WriteLine(returnX);

            //access the sub class method of SubIt
            Console.WriteLine("Subtracting 4 from " + number);
            int returnY = Object.SubIt(number);
            Console.WriteLine(returnY);

            //access the sub class method of MultiplyIt
            Console.WriteLine("Multiplying 15 by " + number);
            int returnZ = Object.TimesIt(number);
            Console.WriteLine(returnZ);

            Console.ReadLine();

        }
    }
}

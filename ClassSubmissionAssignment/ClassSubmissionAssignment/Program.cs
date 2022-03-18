using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc math = new Calc();
            Console.WriteLine("Please submit a number and press enter.");
            int input = Convert.ToInt32(Console.ReadLine());

            int sum;

            math.Divided(input, out sum);

            Console.WriteLine(input + " divided by 2 equals " + sum);
            Console.ReadLine();

            List<int> newList = new List<int>() { 40, 52, 74, 21, 7 };
            math.Output(newList, out int total);
            Console.WriteLine("There are " + total + " items in the list.");
            Console.ReadLine();

            Console.WriteLine("Please submit a number and press enter.");

            int input2 = Convert.ToInt32(Console.ReadLine());
            int sumA = math.Overload(input2);
            Console.WriteLine(input2 + " plus 5 equals " + sumA);
            Console.ReadLine();

            Console.WriteLine("Please enter a number and press enter.");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int sumB = math.Multiple(input2, input3);
            Console.WriteLine("18 plus " + input2 + " plus " + input3 + " equals " + sumB);
            Console.ReadLine();

            int item = 100;
            Static.lastItem(item);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

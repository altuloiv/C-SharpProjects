using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //new object form Calculations class. 
            //taking user input and stores it to a variable. calls upon MathUp method and calculates accordingly
            Calculations inputA = new Calculations();
            Console.WriteLine("Submit a whole number.");
            int a = Convert.ToInt32(Console.ReadLine());
            int result1 = inputA.AddUp(a);
            Console.WriteLine(a + " plus 3 equals {0}.", result1);
            Console.ReadLine();

            Console.WriteLine("Please submit a decimal number to be subtracted by 34.5");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            int result2 = inputA.AddUp(b);
            Console.WriteLine("this equals {0}.", result2);
            Console.ReadLine(); 

            Console.WriteLine("Please submit another Whole Number.");
            string c = Console.ReadLine();
            int result3 = inputA.AddUp(c);
            Console.WriteLine(c + " times 4 equals {0}.", result3);
            Console.ReadLine();
        }
    }
}

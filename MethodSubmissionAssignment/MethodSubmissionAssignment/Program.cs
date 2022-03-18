using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var plus1 = new MethodClass();
                Console.WriteLine("Enter a whole number then press enter.");
                int int1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another whole number then press enter.");
                int int2;
                int sum;
                if (int.TryParse(Console.ReadLine(), out int2))
                {
                    sum = plus1.Plus1(int1, int2);
                }
                else
                {
                    sum = plus1.Plus1(int1);
                }
                Console.WriteLine("The sum of {0} and {1} is {2}.", int1, int2, sum);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, must choose a number greater than zero.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

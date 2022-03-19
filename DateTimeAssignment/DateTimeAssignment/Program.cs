using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine("Current Date and time is " + currentDateTime.ToString());

            Console.WriteLine("Type a number between 1-24 then press enter");

            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In " + hours + " hour(s) it will be " + currentDateTime.AddHours(hours).ToString());

            Console.ReadLine();
        }
    }
}

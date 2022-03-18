using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            IQuittable quitter = new Employee();
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            Employee employee1 = new Employee();
            employee1.firstName = "Albert";
            employee1.lastName = "Tulo IV";

            quitter.Quit();

            employee.Id = 001;
            employee.Id = 002;

            Console.WriteLine(employee==employee1);
        }
    }
}

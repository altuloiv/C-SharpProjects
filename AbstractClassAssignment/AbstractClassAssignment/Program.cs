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

            quitter.Quit();

            employee.Id = 001;

            Console.WriteLine(employee);
        }
    }
}

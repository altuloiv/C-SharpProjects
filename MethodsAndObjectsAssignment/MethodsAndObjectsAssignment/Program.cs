using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates employee class.
            Employee Id = new Employee();
            Id.FirstName = "Sample";
            Id.LastName = "Student";
            Id.SayName();
            Console.ReadLine();
        }
    }
}

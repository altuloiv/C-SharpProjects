using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Hello {0} {1}!", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("The employee quit their job.");
        }
        public int Id { get; set; }

        public static bool operator==(Employee employee, Employee employee1)
        {
            return employee.Id == employee1.Id;
        }

        public static bool operator!=(Employee employee, Employee employee1)
        {
            return employee.Id != employee1.Id;
        }
        
    }
}
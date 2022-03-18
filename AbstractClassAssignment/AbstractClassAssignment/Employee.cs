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
            Console.WriteLine("The employee quit his job.");
        }
        public int Id { get; set; }
        
    }
}
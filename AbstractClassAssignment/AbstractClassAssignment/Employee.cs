using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Hello {0} {1}!", firstName, lastName);
        }
        public int Id { get; set; }
        
    }
}
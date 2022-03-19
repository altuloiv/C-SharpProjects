using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main()
        {
            const string owner = "Jim Carry";
            Console.WriteLine(owner);
            var Cars = new Dictionary<string, int>() { ["Lamborghini"] = 1, ["Ferrari"] = 2, ["Porsche"] = 3, ["Lotsu"] = 4 };
            Console.WriteLine(Cars["Lamborghini"]);
            ConstructorAssignment.HP hP = new ConstructorAssignment.HP("Aston Marten", 5);
            Console.WriteLine(hP.Name + " " + hP.Rank);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass math1 = new MathClass();
            MathClass math2 = new MathClass();
            math1.Addition(10, 34);
            math2.Addition(num1: 22, num2: 41);
        }
    }
}

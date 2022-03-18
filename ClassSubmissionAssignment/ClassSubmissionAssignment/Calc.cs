using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Calc
    {
        public void Divided(int input, out int sum)
        {
            sum = input / 2;
        }
        public void Output(List<int> newList, out int total)
        {
            total = newList.Count;
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
        }
        public int Overload(int input2)
        {
            int x = 5;
            int sumB = x + input2;
            return sumB;
        }
        public int Multiple(int input2, int input3)
        {
            int a = 3;
            int b = 6;
            int c = 9;
            int sumC = a + b + c + input2 + input3;
            return sumC;
        }
    }
}
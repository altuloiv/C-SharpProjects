using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Calculations
    {
        public int AddUp(int x)
        {
            int inputA = x + 3;
            return inputA;
        }

        public int AddUp(decimal y)
        {
            decimal inputB = y - 34.5m;
            return Convert.ToInt32(inputB);
        }
        public int AddUp (string z)
        {
            int inputC = Convert.ToInt32(z);
            int inputD = inputC * 4;
            return inputD;
        }
    }
}
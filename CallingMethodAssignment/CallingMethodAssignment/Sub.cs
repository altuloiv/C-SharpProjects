using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallingMethodAssignment
{
	public class Sub
	{
		public int AddIt(int number)
		{
			int x = 30;
			return number + x;
		}
		public int SubIt(int number)
        {
			int y = 4;
			return number - y;
        }
		public int TimesIt(int number)
        {
			int z = 15;
			return number * z;
        }
	}
}

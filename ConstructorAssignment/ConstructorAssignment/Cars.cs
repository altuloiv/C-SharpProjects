using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class HP
    {
        public HP() : this(null, 0)
        {

        }
        public HP(string name, int rank)
        {
            Name = name;
            Rank = rank;
        }
        public string Name { get; set; }
        public int Rank { get; set; }
    }

}
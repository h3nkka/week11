using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Dice
    {
        public List<int> Throw(int times)
        {
            List<int> rollList = new List<int>();
            for (int i = 0; i < times; i++)
            {
                Random RNG = new Random(Guid.NewGuid().GetHashCode());
                rollList.Add(RNG.Next(1, 7));
            }
            return rollList;
        }
    }
}

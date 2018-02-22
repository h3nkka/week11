using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class FishingSpot
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public FishingSpot(string n, string l)
        {
            Name = n;
            Location = l;
        }
    }
}

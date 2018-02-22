using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Fish
    {
        public string Species { get; set; }
        public double Length { get; set; }
        public double Weight{ get; set; }

        public FishingSpot Spot { get; set; }

        public Fish(string s, double l, double w, FishingSpot fs)
        {
            Species = s;
            Length = l;
            Weight = w;
            Spot = fs;
        }

        public int CompareTo(Fish compareFish)
        {
            // A null value means that this object is greater.
            if (compareFish == null)
                return 1;

            else
                return compareFish.Weight.CompareTo(this.Weight);
        }
    }
}

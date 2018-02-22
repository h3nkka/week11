using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Fisherman
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Fish> fishList { get; set; }

        public Fisherman(string n, string pn)
        {
            Name = n;
            PhoneNumber = pn;
            fishList = new List<Fish>();
        }
        public Fisherman(string n, string pn, List<Fish> fl)
        {
            Name = n;
            PhoneNumber = pn;
            fishList = new List<Fish>(fl);
        }
    }
}

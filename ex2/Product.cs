using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string n, double p)
        {
            Name = n;
            Price = p;
        }
    }
}

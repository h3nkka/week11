using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Cart
    {
        public List<Product> productList { get; set; }

        public Cart()
        {
            productList = new List<Product>();
        }
    }
}

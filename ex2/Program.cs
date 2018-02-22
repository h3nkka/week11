using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.productList.Add(new Product("Kalja", 5.5));
            cart.productList.Add(new Product("Makkara", 8.5));
            cart.productList.Add(new Product("Hienosokeri", 3.25));
            cart.productList.ForEach(x => Console.WriteLine("{0} ${1}", x.Name,x.Price));
            Console.ReadKey(true);
        }
    }
}

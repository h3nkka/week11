using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Sum = {0}", ArrayCalcs.Sum(array));
            Console.WriteLine("Average = {0}", ArrayCalcs.Average(array));
            Console.WriteLine("Min = {0}", ArrayCalcs.Min(array));
            Console.WriteLine("Max = {0}", ArrayCalcs.Max(array));
        }
    }
}

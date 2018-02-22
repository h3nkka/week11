using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        private static int i = 1;
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine("Rolling the dice once: {0}", dice.Throw(1));
            Console.WriteLine("Input amount of dice rolls.");
            int rolls = Int32.Parse(Console.ReadLine());
            List<int> rollList = dice.Throw(rolls);          

            Func<int, bool> function = IsNumber;
            Console.WriteLine("Rolling the dice {0} times and counting the average of the rolls: {1}",rolls,rollList.Average());
            for (; i <= 6; i++)
            {
                Console.WriteLine("Rolled {0}s: {1}", i, rollList.Count(function));
            }
            Console.ReadKey(true);
        }

        public static bool IsNumber(int integer)
        {
            return integer == i;
        }
    }
}

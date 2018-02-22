using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static List<Fisherman> fishermanList;
        static void Main(string[] args)
        {
            fishermanList = new List<Fisherman>();
            fishermanList.Add(new Fisherman("Henri", "1337-420", new List<Fish>() { new Fish("Muikku", 20.0, 30.5, new FishingSpot("Jyväskylä", "Jyväsjärvi")), new Fish("Ahven", 90.0, 60.75, new FishingSpot("Muurame", "Muuratjärvi")) }));
            fishermanList.Add(new Fisherman("Keke", "7447-690", new List<Fish>() { new Fish("Lentokala", 100.0, 100.0, new FishingSpot("Huitsin Nevada", "Nevadajärvi")), new Fish("Piraija", 40.0, 55, new FishingSpot("Brasilia", "Amazon")) }));
            while (true)
            {
                Console.WriteLine("MENU\n1: Add Fisherman\n2: Print All Fisherman/Fish Info\n3: Print All Fish Info Sorted By Weight");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddFisherMan();
                        break;
                    case 2:
                        PrintInfo();
                        break;
                    case 3:
                        PrintFishSorted();
                        break;
                }
                Console.ReadKey(true);
            }
        }

        public static void AddFisherMan()
        {
            Console.WriteLine("Name:");
            string n = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string pn = Console.ReadLine();
            Fisherman newFisherman = new Fisherman(n, pn);

            while (true)
            {
                Console.WriteLine("Input fish? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Input species, length and weight of fish, separated by enter presses. Then input location name and specified location.");
                    newFisherman.fishList.Add(new Fish(Console.ReadLine(), Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()), new FishingSpot(Console.ReadLine(), Console.ReadLine())));
                    Console.WriteLine("New fish added.");
                }
                else
                    break;
            }
            fishermanList.Add(newFisherman);
            Console.WriteLine("Fisherman {0} successfully added!", n);
        }
        public static void PrintInfo()
        {
            foreach(Fisherman fm in fishermanList)
            {
                Console.WriteLine("{0} (p. {1})\nFish caught:\n", fm.Name, fm.PhoneNumber);
                foreach(Fish f in fm.fishList)
                {
                    Console.WriteLine("{0} (l: {1}cm w: {2}g)\nLocation: {3}, {4}\n", f.Species, f.Length, f.Weight, f.Spot.Name, f.Spot.Location);
                }
            }
        }

        public static void PrintFishSorted()
        {
            List<Fish> allFish = new List<Fish>();
            foreach (Fisherman fm in fishermanList)
            {

                fm.fishList.ForEach(x => allFish.Add(x));                
            }
            allFish.Sort(delegate (Fish x, Fish y) {
                if (x.Weight == 0 && y.Weight == 0) return 0;
                else if (x.Weight == 0) return 1;
                else if (y.Weight == 0) return -1;
                else return y.Weight.CompareTo(x.Weight);
            });
            allFish.ForEach(x => Console.WriteLine("{0} (l: {1}cm w: {2}g)\nLocation: {3}, {4}\n", x.Species, x.Length, x.Weight, x.Spot.Name, x.Spot.Location));
        }
    }
}

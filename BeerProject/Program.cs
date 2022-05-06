using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beer beer1 = new Beer("Tuborg", "RedLobster", BeerType.Bock, 100, 8.4);
            Beer beer2 = new Beer("Carlsberg", "BlueHedgehog", BeerType.Lager, 70, 7.7);
            Beer beer5 = new Beer("Hersinger", "hof", BeerType.Münchener, 30, 9.2);
            Console.WriteLine(beer1);
            Console.WriteLine(beer2);
            Console.WriteLine(beer5);
            beer1.add(beer2);
            Console.WriteLine(beer1);
            Beer beer3 = beer1.mix(beer5);
            Beer beer4 = Beer.mix(beer2,beer1);
            Beer[] beers = new Beer[5];
            beers[0]=beer1;
            beers[1] = beer2;
            beers[2] = beer3;
            beers[3] = beer4;
            beers[4] = beer5;
            Array.Sort(beers,new SortingBeerBy(SortBy.Percent));
            Console.WriteLine();
            Console.WriteLine("Sorted by Percent");
            foreach (Beer beer in beers)
            {
                Console.WriteLine(beer);
            }
            Array.Sort(beers, new SortingBeerBy(SortBy.Unit));
            Console.WriteLine();
            Console.WriteLine("Sorted by Units");
            foreach (Beer beer in beers)
            {
                Console.WriteLine(beer);
            }
            Array.Sort(beers, new SortingBeerBy(SortBy.Volume));
            Console.WriteLine();
            Console.WriteLine("Sorted by Volume");
            foreach (Beer beer in beers)
            {
                Console.WriteLine(beer);
            }
            Console.ReadKey();
        }
    }
}

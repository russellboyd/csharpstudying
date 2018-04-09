using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string> { "New York", "Manchester", "Sheffield", "Paris" };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            //bigCities.IntersectWith(citiesInUK);
            //bigCities.UnionWith(citiesInUK);
            //bigCities.SymmetricExceptWith(citiesInUK);
            bigCities.ExceptWith(citiesInUK);
            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }

        }
    }
}   
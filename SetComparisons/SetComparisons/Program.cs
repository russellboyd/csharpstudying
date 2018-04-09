using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigUkCities = new HashSet<string> { "Manchester", "Sheffield" };
            var ukCities = new HashSet<string> { "Sheffield", "Ripon", "Truro", "Manchester" };
            var bigCitiesArr = new string[] { "New York", "Manchester", "Sheffield", "Paris" };
            bool uKIsSubset = ukCities.IsSubsetOf(bigCitiesArr);
            bool bigUkIsSubset = bigUkCities.IsSubsetOf(bigCitiesArr);

            Console.WriteLine("UK cities subset of big cities? " + uKIsSubset);
            Console.WriteLine("Big UK cities subset of big cities? " + bigUkIsSubset);
        }
    }
}

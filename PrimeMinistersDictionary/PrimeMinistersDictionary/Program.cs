using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinistersDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var PrimeMinisters = new Dictionary<string,PrimeMinister>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            PrimeMinister pm;
            bool found = PrimeMinisters.TryGetValue("DC", out pm);
            if (found)
            {
                Console.WriteLine("Value is: " + pm.ToString() + "\r\n");
            }
            else
            {
                Console.WriteLine("Value was not in the dictionary.");
            }

            PrimeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);
            PrimeMinisters["JM"] = new PrimeMinister("John Major", 1990);
            PrimeMinisters.Add("GB", new PrimeMinister("Gordon Brow", 2007));

            foreach (var pms in PrimeMinisters.Values)
            {
                Console.WriteLine(pms);
            }
        }
    }
}

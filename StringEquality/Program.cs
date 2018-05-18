using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace StringEquality
{
    class Program
    {
        static void Main(string[] args)
        {
		bool areEqual = string.Equals("Apple", "Pineapple", StringComparison.CurrentCultureIgnoreCase);
		int cmpResult = string.Compare("Apple", "Pineapple", CultureInfo.GetCultureInfo("fr-FR"),CompareOptions.IgnoreSymbols);
		areEqual = (cmpResult == 0);

		//case-sensitive ordinal comparison
		areEqual = ("Apple" == "Pineapple");
		areEqual = "Apple".Equals("Pineapple");
	}
    }
}

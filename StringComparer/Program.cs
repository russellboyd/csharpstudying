using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;

namespace StringComparer
{
    class Program
    {
        static void Main(string[] args)
        {
		var names = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
		names.Add("apple");
		names.Add("pear");
		names.Add("pineapple");
		names.Add("Apple");

		foreach(string name in names)
		       Console.WriteLine(name);

		
		}
    }
}
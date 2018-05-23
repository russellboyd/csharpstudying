using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringComparer
{
    class Program
    {
        static void Main(string[] args)
        {
		var names = new HashSet<string>();
		names.Add("apple");
		names.Add("pear");
		names.Add("pineapple");
		names.Add("Apple");

		foreach(string name in names)
		       Console.WriteLine(name);

		
	}
    }
}
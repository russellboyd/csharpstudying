using System;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = {"orange", "banana", "pear", "apple"};
	    Array.Sort(list);

	    foreach(var item in list)
	    	Console.WriteLine(item);
        }
    }
}

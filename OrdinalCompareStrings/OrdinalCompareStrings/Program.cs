﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdinalCompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = string.Compare("lemon", "LEMON", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Compare result is " + result);
        }
    }
}

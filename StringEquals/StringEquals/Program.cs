﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            string banana = "banana";
            string banana2 = string.Copy(banana);

            Console.WriteLine(banana);
            Console.WriteLine(banana2);
            Console.WriteLine(banana.Equals((object)banana2));
        }
    }
}

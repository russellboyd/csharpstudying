﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chocolate = new Food("chocolate");

            Console.WriteLine(banana.Equals(null));
            Console.WriteLine(object.Equals(banana, null));
            Console.WriteLine(object.Equals(null, banana));
            Console.WriteLine(object.Equals(null, null);

            Console.WriteLine(banana);
            Console.WriteLine(banana2);

            Console.WriteLine(banana.Equals((object) banana2));
            Console.WriteLine(ReferenceEquals(banana, banana2));


        }
    }
}

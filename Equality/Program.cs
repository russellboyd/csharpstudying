﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality
{
    class Program
    {
        static void Main(string[] args)
        {
		Food[] list = {
		new Food("orange",FoodGroup.Fruit),
		new Food("banana",FoodGroup.Fruit),
		new Food("pear",FoodGroup.Fruit),
		new Food("apple",FoodGroup.Fruit)
		};

		Array.Sort(list);

		foreach(var item in list)
			    Console.WriteLine(item);
		

        }
    }
}


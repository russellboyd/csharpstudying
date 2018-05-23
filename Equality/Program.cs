using System;
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
		/*
		Food[] list = {
		new Food("orange",FoodGroup.Fruit),
		new Food("banana",FoodGroup.Fruit),
		new Food("pear",FoodGroup.Fruit),
		new Food("apple",FoodGroup.Fruit),
		new CookedFood("baked", "apple", FoodGroup.Fruit),
		};

		SortAndShowList(list);

		Food[] list2 = {
		new CookedFood("baked", "apple", FoodGroup.Fruit),
		new Food("pear", FoodGroup.Fruit),
		new Food("apple", FoodGroup.Fruit)
		};
		
		Console.WriteLine();
		SortAndShowList(list2);
		*/
		
		//var foodItems = new HashSet<FoodItem>(FoodItemEqualityComparer.Instance);
		var foodItems = new HashSet<FoodItem>(EqualityComparer<FoodItem>.Default);
		foodItems.Add(new FoodItem("apple", FoodGroup.Fruit));
		foodItems.Add(new FoodItem("pear", FoodGroup.Fruit));
		foodItems.Add(new FoodItem("pineapple", FoodGroup.Fruit));
		foodItems.Add(new FoodItem("apple", FoodGroup.Fruit));

		foreach(var foodItem in foodItems)
			    Console.WriteLine(foodItem);
        }

	static void SortAndShowList(Food[] list)
	{
		Array.Sort(list, FoodNameComparer.Instance);
		
		foreach(var item in list)
			    Console.WriteLine(item);

	}
    }
}


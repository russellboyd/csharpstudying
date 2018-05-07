using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);

            Console.WriteLine(apple);
            Console.WriteLine(stewedApple);
        }

        static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if (food1 == food2)
            {
                Console.WriteLine(string.Format("{0, 12} == {1}", food1, food2));
            }
            else
            {
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
            }
        }
    }
}

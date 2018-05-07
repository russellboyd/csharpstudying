using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodItems banana = new FoodItems("banana", FoodGroup.Fruit);
            FoodItems banana2 = new FoodItems("banana", FoodGroup.Fruit);
            FoodItems chocolate = new FoodItems("chocolate", FoodGroup.Sweets);

            Console.WriteLine("banana == banana2: " + (banana == banana2));
            Console.WriteLine("banana2 == chocolate: " + (banana2 == chocolate));
            Console.WriteLine("chocolate == banana : " + (chocolate == banana));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>(12) { "Jimmy Carter", "Ronald Reagan", "George HW Bush", "Bill CLinton", "George W Bush" };

            Console.WriteLine("Before: ");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");

            presidents.Add("Barack Obama");
            presidents.Add("Bill Gates");
            presidents.Add("Steven Spielberg");
            presidents.Add("Aaron Skonnard");

            presidents.Remove("Bill Gates");

            Console.WriteLine("\r\nAfter adding: ");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");
            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }
    }
}

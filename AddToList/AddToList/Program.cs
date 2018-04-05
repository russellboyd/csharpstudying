using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
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

            //var copy = new ReadOnlyCollection<string>(presidents);
            //var copy = presidents.AsReadOnly();
            //^do the same thing

            string[] copy = presidents.ToArray();

            BadCode(copy);

            presidents.Add("Bill Gates");
            presidents.Add("Steven Spielberg");
            presidents.Add("Aaron Skonnard");
            Console.WriteLine("\r\nAfter adding: ");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity + "\r\n");

            //string who = presidents[10]; throws argumentoutofbounds because there aren't 10 elements in the list<t>

            string firstElement = presidents[0];

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
            
            
        }
        static void BadCode(IList<string> lst)
        {
            lst.RemoveAt(2);
        }
    }
}

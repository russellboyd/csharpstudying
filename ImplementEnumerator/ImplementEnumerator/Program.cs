using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            AllDaysOfWeek allDays = new AllDaysOfWeek();
            foreach (string day in allDays)
            {
                Console.WriteLine(day);
            }
        }
    }
    public class AllDaysOfWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Calling generic enumerator.");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
            //yield return is different from regular return. yield return creates and is used for a MoveNext in the generated enumerator.
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            
        }

        
    }
}

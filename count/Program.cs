using System;

namespace count
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
          ICollection<string> collection = (ICollection<string>)daysOfWeek;
          collection.Count()
          Console.WriteLine("Count = " + collection.Count);
          Console.WriteLine("Length = " + daysOfWeek.Length);
          
          
        }
    }
}

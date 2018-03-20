using System;

namespace FindElements
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
        int indexOfTues = Array.IndexOf(daysOfWeek, "Tuesday");
        string[] allWith6Chars = Array.FindAll(daysOfWeek, x=>x.Length == 6);
        foreach(string item in allWith6Chars)
        {
          Console.WriteLine(item);
        }
        Console.WriteLine(indexOfTues);
        Console.WriteLine(indexOfW);
        Console.WriteLine(daysOfWeek[indexOfW]);
        Console.WriteLine();
        }
    }
}

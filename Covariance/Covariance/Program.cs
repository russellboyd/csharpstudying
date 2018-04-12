using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            object obj = str;

            //var strList = new List<string> { "Monday", "Tuesday" };
            //List<object> objList = (List<object>)strList;
            var strList = new string[] { "Monday", "Tuesday" };
            object[] objList = strList; //you can cast array of a dervied type to an array of the base type
            objList[0] = 5; // can't happen because you are trying to put an int into a string

            IEnumerable<object> objEnum = strList;//this works because strings are objects too.
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int threeAgain = 3;
            bool intCmp = three == threeAgain;
            Console.WriteLine(string.Format("Compare ints : {0}", intCmp));

            bool objCmp = (object)three == (object)threeAgain;
            Console.WriteLine(string.Format("compare objects : {0}",objCmp));

            //objects are reference types which is why objCmp is false.  the integers have been boxed into different reference instances.

            bool itfCmp = ((IComparable<int>)three == (IComparable<int>)threeAgain);
            Console.WriteLine(string.Format("Compare interfaces : {0}", itfCmp));
        }
    }
}

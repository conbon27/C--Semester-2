using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;

            Example1(val);
            Console.WriteLine(val); // Still 0

            Example2(ref val);
            Console.WriteLine(val); // Now 2!

            Example3(out val);
            Console.WriteLine(val); // Now 3!
        }

        static void Example1(int value)
        {
            value = 1;
        }
        static void Example2(ref int value)
        {
            value = 2;
        }
        static void Example3(out int value)
        {
            value = 3;
        }
    }
}

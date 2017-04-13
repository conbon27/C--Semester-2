using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsExample
{
    class TheClass
    {
        public int x;
    }
    struct TheStruct
    {
        public int x;
    }

    class TestClass
    {
        public static void structTaker(TheStruct s)
        {
            s.x = 5;
        }

        public static void classTaker(TheClass s)
        {
            s.x = 5;
        }
    
        static void Main(string[] args)
        {
        TheStruct a = new TheStruct();
        TheClass b = new TheClass();
        a.x = 1;
        b.x = 1;

            structTaker(a);
            classTaker(b);
            Console.WriteLine("a.x = {0}", a.x);
            Console.WriteLine("b.x = {0}", b.x);
            Console.ReadKey();
        }
    }
}

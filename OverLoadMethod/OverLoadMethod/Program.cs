using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadMethod
{
    class Overloadmethod
    {
        //method declared with 1 integer parameter
        void show(int x)
        {
            Console.WriteLine(x);
        }
        // method declared with 2 integer parameters.
        void show(int a, int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            //object created
            Overloadmethod a = new Overloadmethod();
            // methods called by passing respective values
            a.show(100);
            a.show(300, 500);
            Console.Read();
        }
    }
}

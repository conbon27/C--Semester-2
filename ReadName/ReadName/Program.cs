using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadName
{
    class ReadName
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Hello, please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", welcome to NUI Galway.");
        }
    }
}

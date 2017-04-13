using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Supermarket
    {
        static void Main()
        {
            Item si = new Item();
            si.CreateItem();
            si.Describe();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class PreyTester
    {
        static void Main()
        {
            Cat tabby = new Cat();
            tabby.AttackSpeed = 10;

            Fish bubbles = new Fish();
            bubbles.FleeSpeed = 12;

            tabby.Purr();
            tabby.Attack(bubbles);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicDog
{
    class DogTest
    {
        public static void Main(string[] args)
        {
            Animal a1 = new PolymorphicDog.Animal();
            a1.Talk();
            a1.Greet();
            a1.Sing();

            Animal a2 = new Dog();
            a2.Talk();
            a2.Greet();
            a2.Sing();

            Dog a3 = new Dog();
            a3.Talk();
            a3.Greet();
            a3.Sing();

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    interface IPredator : IAnimal
    {
        int AttackSpeed { get; set; }

        void Attack(IPrey prey);
    }
}

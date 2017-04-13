using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Cat : IPredator
    {
        private int _attackSpeed;
        private string _name;

        public int AttackSpeed
        {
            get
            {
                return _attackSpeed;
            }
            set
            {
                _attackSpeed = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public void Attack(IPrey prey)
        {
            if (_attackSpeed > prey.Fleespeed)
                Console.WriteLine("Caught prey");
            else
                Console.WriteLine("Prey escaped");
            }
            public void Purr()
        {
            Console.WriteLine("Cat purred");
        }
        }
    }


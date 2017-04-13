using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceAssignment4
{
    class Diamonds : Card
    {
        private string diamonds;
        public Diamonds(int value) : base(value)
        {
        }
        public Diamonds(string suit)
        {
            diamonds = suit;
        }
        public Diamonds()
        {
            suit = 3;
        }
        public static void add(Card card)
        {
            add(card);
        }
    }
}

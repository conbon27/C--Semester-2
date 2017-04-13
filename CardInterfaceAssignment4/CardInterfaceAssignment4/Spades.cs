using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceAssignment4
{
    class Spades : Card
    {
        private string spades;
        public Spades(int value) : base(value)
        {
        }
        public Spades()
        {
            suit = 1;
        }
        public Spades(string suit)
        {
            spades = suit;
        }
        public static void add(Card card)
        {
            add(card);
        }
    }
}

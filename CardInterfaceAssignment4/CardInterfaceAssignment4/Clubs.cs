using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceAssignment4
{
    class Clubs : Card
    {
        private string clubs;
        public Clubs(int value) : base(value)
        {
        }
        public Clubs()
        {
            suit = 2;
        }
        public Clubs(string suit)
        {
            clubs = suit;
        }
        public static void add(Card card)
        {
            add(card);
        }
    }
}

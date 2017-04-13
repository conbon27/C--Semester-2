using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceAssignment4
{
    class Hearts : Card
    {
        private string hearts;
        public Hearts(int value) : base(value)
        {
        }
        public Hearts(string suit)
        {
            hearts = suit;
        }
        public string getSuit
        {
            get
            {
                return hearts;
            }
        }
        public Hearts()
        {
            suit = 4;
        }
        public static void add(Card card)
        {
            add(card);
        }
        // polymorphic use of the print method from the superclass
        // original output replaced when called on a Hearts object.
        public override string print()
        {
            Hearts h = new Hearts();
            Console.WriteLine("This is the same method but overriden method in the Heart class");
            return h.ToString();
        }
    }
}

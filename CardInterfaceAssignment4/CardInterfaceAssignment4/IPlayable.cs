using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceAssignment4
{
    //method signatures which will be fleshed out in classes which implement
    interface IPlayable
    {
        // deal method for type Card
        Card Deal();
        // shuffle method
        void Shuffle();
        // play method to compare dealt cards & declare winning
        List<Card> Play();
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CardInterfaceAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphic use of interface
            // instantiate a new interface of type card - which implements the interface being instantiated
            IPlayable play = new Card();
            play.Deal();
            // methods can therefore be called from that instantiation. 
            
            Card card1 = new Card();
            // test to show all individual cards within card array
            Console.WriteLine("All cards:");
            foreach (Card c in card1.Cards)
            {   
                Console.WriteLine(c.CardNo+ " " + c.GetType().Name);
            }
            // shuffle method
            Console.WriteLine("Shuffle1:");
            card1.Shuffle();
            foreach (Card c in card1.Cards)
            {
                Console.WriteLine(c.CardNo + " " + c.GetType().Name);
            }
            // deal method dealing to show all shuffled cards
            Console.WriteLine("Deal1:");
            card1.Deal();
            
            foreach (Card c in card1.Cards)
            {
                Console.WriteLine(c.CardNo + " " + c.GetType().Name);
            }
            // sorts objects in an array asce
            Console.WriteLine("After sorting:");
            Array.Sort(card1.Cards);
            foreach (Card c in card1.Cards)
            {
                Console.WriteLine(c.CardNo + " " + c.GetType().Name);
            }
            //reshuffles cards to play game
            Console.WriteLine("Reshuffle...");
            card1.Shuffle();
            // create new toPlay array to facilitate game
            List<Card> toPlay = card1.Play();
            // call play method which deals 3 cards
            foreach (Card d in toPlay)
            {
                Console.WriteLine(d.CardNo + " " + d.GetType().Name);
            }
            // sort method decides who is the winner
            toPlay.Sort();
            Console.WriteLine("The winner (followed in order by the losers) are: ");
            foreach (Card d in toPlay)
            {
                Console.WriteLine(d.CardNo + " " + d.GetType().Name);
            }
            Card poly = new Card();
            poly.print();
            Hearts h = new Hearts();
            h.print();
            Console.Read();
        }
    }
}

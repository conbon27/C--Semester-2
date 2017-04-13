using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInterfaceAssignment4
{
    class Card : IPlayable, IComparable<Card>
    {
        private int faceValue;
        protected int suit;
        const int hand = 2;
        const int numPlayers = 2;
        
        // declares & populates card array with 4 different types based on subclasses
        Card[] cards = new Card[40];
        int[] deck = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };             

        public Card() {
            int i = 0;
            foreach (int n in deck)
            {
                cards[i] = new Hearts(n);
                i++;
            }
            foreach (int n in deck)
            {
                cards[i] = new Spades(n);
                i++;
            }
            foreach (int n in deck)
            {
                cards[i] = new Diamonds(n);
                i++;
            }
            foreach (int n in deck)
            {
                cards[i] = new Clubs(n);
                i++;
            }
        }
        
        public Card[] Cards
        { 
            get { 
        return cards;
            }
        }


        public Card(int cardNo)
        {
            faceValue = cardNo;
        }
        public int CardNo
        {
            get
            {
                return faceValue;
            }
        }


        int currentCard = 0;

        // method body from interface
        public Card Deal()
        {
            if (currentCard < deck.Length)
                return cards[currentCard++];
            else
            {
                return null;
            }
        }
        // method body from interface
        // creates a Card List, populates it and outputs text
        public List<Card> Play()
        {
            Console.WriteLine("The cards selected were:");
            List<Card> playCard = new List<Card>();
            playCard.Add(cards[0]);
            playCard.Add(cards[1]);
            playCard.Add(cards[2]);
            return playCard;
        }
     
            static Random r = new Random();
            private const int NUMB_CARDS = 40;

        // method body from interface
            public void Shuffle()
        { 
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            { 
                int second = r.Next(NUMB_CARDS);
                Card temp = Cards[first];
                Cards[first] = Cards[second];
                Cards[second] = temp;
            }
        }
        // using IComparable interface - compares & declares winner from deal

        // implementation of IComparable
        // compares 1 card to another by card no.
        public int CompareTo(Card other)
        {
            if (CardNo == other.CardNo)
            {
                return suit.CompareTo(other.suit);
            }
            else
            {
                return other.CardNo.CompareTo(CardNo);
            }
        }

        // print method - polymorphism will be shown as subclasses will
        // use this method (overridden) & be called in the tester.
        public virtual string print()
        {
            Card k = new Card();
            Console.WriteLine("Polymorphism: This is the Card from the virtual method");
            return "regular card";   
       }
    }
}


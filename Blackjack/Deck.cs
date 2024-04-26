using System.Collections.Generic;

namespace Blackjack
{
    internal class Deck
    {

        public List<Card> CardDeck = new List<Card>(); 

        public List<Card> getDeck()
        {
            return CardDeck;
        }


        private static Random rng = new Random();

        public void ShuffleDeck()
        {
            int n = CardDeck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = CardDeck[k];
                CardDeck[k] = CardDeck[n];
                CardDeck[n] = value;
            }
        }

        public void CreateDeck()
        {
            // clubs
            CardDeck.Add(new Card("Clubs", 2, 0, "2"));
            CardDeck.Add(new Card("Clubs", 3, 1, "3"));
            CardDeck.Add(new Card("Clubs", 4, 2, "4"));
            CardDeck.Add(new Card("Clubs", 5, 3, "5"));
            CardDeck.Add(new Card("Clubs", 6, 4, "6"));
            CardDeck.Add(new Card("Clubs", 7, 5, "7"));
            CardDeck.Add(new Card("Clubs", 8, 6, "8"));
            CardDeck.Add(new Card("Clubs", 9, 7, "9"));
            CardDeck.Add(new Card("Clubs", 10, 8, "10"));
            CardDeck.Add(new Card("Clubs", 10, 9, "jack"));
            CardDeck.Add(new Card("Clubs", 10, 10, "Queen"));
            CardDeck.Add(new Card("Clubs", 10, 11, "King"));
            CardDeck.Add(new Card("Clubs", 1, 12, "Ace"));

            // spades
            CardDeck.Add(new Card("Spades", 2, 0, "2"));
            CardDeck.Add(new Card("Spades", 3, 1, "3"));
            CardDeck.Add(new Card("Spades", 4, 2, "4"));
            CardDeck.Add(new Card("Spades", 5, 3, "5"));
            CardDeck.Add(new Card("Spades", 6, 4, "6"));
            CardDeck.Add(new Card("Spades", 3, 1, "3"));
            CardDeck.Add(new Card("Spades", 7, 5, "7"));
            CardDeck.Add(new Card("Spades", 8, 6, "8"));
            CardDeck.Add(new Card("Spades", 9, 7, "9"));
            CardDeck.Add(new Card("Spades", 10, 8, "10"));
            CardDeck.Add(new Card("Spades", 10, 9, "jack"));
            CardDeck.Add(new Card("Spades", 10, 10, "Queen"));
            CardDeck.Add(new Card("Spades", 10, 11, "King"));
            CardDeck.Add(new Card("Spades", 1, 12, "Ace"));

            // hearts
            CardDeck.Add(new Card("Hearts", 2, 0, "2"));
            CardDeck.Add(new Card("Hearts", 3, 1, "3"));
            CardDeck.Add(new Card("Hearts", 4, 2, "4"));
            CardDeck.Add(new Card("Hearts", 5, 3, "5"));
            CardDeck.Add(new Card("Hearts", 6, 4, "6"));
            CardDeck.Add(new Card("Hearts", 7, 5, "7"));
            CardDeck.Add(new Card("Hearts", 8, 6, "8"));
            CardDeck.Add(new Card("Hearts", 9, 7, "9"));
            CardDeck.Add(new Card("Hearts", 10, 8, "10"));
            CardDeck.Add(new Card("Hearts", 10, 9, "jack"));
            CardDeck.Add(new Card("Hearts", 10, 10, "Queen"));
            CardDeck.Add(new Card("Hearts", 10, 11, "King"));
            CardDeck.Add(new Card("Hearts", 1, 12, "Ace"));

            // diamonds
            CardDeck.Add(new Card("Diamonds", 2, 0, "2"));
            CardDeck.Add(new Card("Diamonds", 3, 1, "3"));
            CardDeck.Add(new Card("Diamonds", 4, 2, "4"));
            CardDeck.Add(new Card("Diamonds", 5, 3, "5"));
            CardDeck.Add(new Card("Diamonds", 6, 4, "6"));
            CardDeck.Add(new Card("Diamonds", 7, 5, "7"));
            CardDeck.Add(new Card("Diamonds", 8, 6, "8"));
            CardDeck.Add(new Card("Diamonds", 9, 7, "9"));
            CardDeck.Add(new Card("Diamonds", 10, 8, "10"));
            CardDeck.Add(new Card("Diamonds", 10, 9, "jack"));
            CardDeck.Add(new Card("Diamonds", 10, 10, "Queen"));
            CardDeck.Add(new Card("Diamonds", 10, 11, "King"));
            CardDeck.Add(new Card("Diamonds", 1, 12, "Ace"));
        }
    }
}
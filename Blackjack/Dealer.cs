using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Dealer
    {
        public void dealCard(PlayerEntity player, Deck deck)
        {
            Random rng = new Random();
            int num = rng.Next(deck.CardDeck.Count);
            //Console.WriteLine(deck.CardDeck[num]);
            player.receiveCard(deck.CardDeck[num]);
            deck.CardDeck.Remove(deck.CardDeck[num]);
        }
    }
}

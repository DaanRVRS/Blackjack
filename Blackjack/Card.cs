using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Card
    {
        private string suit;
        private int points;
        private int id;
        private string type;

        public Card(string suit2, int points2, int id2, string type2) {
            // creating new card
            this.suit = suit2;
            this.points = points2;
            this.id = id2;
            this.type = type2;
        }
        public string Suit { get { return this.suit; } set { this.suit = value; } }
        public int Points { get { return this.points; } set { this.points = value; } }
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Type { get { return this.type; } set { this.type = value; } }

        public override string ToString()
        {
            return this.Type + " of " + this.Suit + " (" + this.Points + ")";
        }
    }
}

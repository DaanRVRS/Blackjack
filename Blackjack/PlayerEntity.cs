using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class PlayerEntity
    {
        public List<PlayerEntity> playerList = new List<PlayerEntity>();

        public List<PlayerEntity> getPlayers()
        {
            return playerList;
        }

        public string getName()
        {
            return this.name;
        }

        public static int playerIndex = 0;
        private int id;
        private int bet;
        public int cardsPulled;
        private string name;
        private List<Card> hand;

        public PlayerEntity(int bet, int cardsPulled, string name)
        {
            this.id = playerIndex;
            this.bet = bet;
            this.cardsPulled = cardsPulled;
            this.name = name;
            this.hand = new List<Card>();
            playerIndex++;
        }

        public void receiveCard(Card card)
        {
            hand.Add(card);
        }

        public int getHandTotal()
        {
            int total = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                total = total + hand.ToArray()[i].Points;
            }

            return total;
        }

        public void createPlayerList(string Name)
        {
            playerList.Add(new PlayerEntity(100, 0, Name));
        }

        public string getStarterPointsAmount()
        {
            return " | Punten eerste kaart: " + this.hand.ToArray()[0].Points;
        }

        public override string ToString()
        {
            if(this.hand.Count == 0)
            {
                return this.id + ") " + this.name + " > $" + this.bet;
            } else
            {
                return this.id + ") " + this.name + " > $" + this.bet + getStarterPointsAmount();
            }
        }
    }
}

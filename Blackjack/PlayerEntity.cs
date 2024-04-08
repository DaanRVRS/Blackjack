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

        public static int playerIndex = 0;
        private int id;
        private int bet;
        private int cardsPulled;
        private string name;
        private List<Card> hand;

        public PlayerEntity(int bet, int cardsPulled, string name, List<Card> hand)
        {
            this.id = playerIndex;
            this.bet = bet;
            this.cardsPulled = cardsPulled;
            this.name = name;
            playerIndex++;
            this.hand = hand;
        }

        public void createPlayerList(string Name)
        {
            playerList.Add(new PlayerEntity(100, 0, Name, null));
        }

        public override string ToString()
        {
            return this.id + ") " + this.name + " > $" + this.bet;
        }
    }
}
 
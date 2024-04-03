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

        public PlayerEntity(int bet, int cardsPulled, string name)
        {
            this.id = playerIndex;
            this.bet = bet;
            this.cardsPulled = cardsPulled;
            this.name = name;
            playerIndex++;
        }

        public void createPlayerList(string Name)
        {
            playerList.Add(new PlayerEntity(100, 0, Name));
        }

        public override string ToString()
        {
            return this.id + ") " + this.name + " > $" + this.bet;
        }
    }
}
 
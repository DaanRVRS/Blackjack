using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class PlayerEntity
    {

        public PlayerEntity(int id, int bet, int cardsPulled)
        {
            playerId = id;
            playerBet = bet;
            playerCardsPulled = cardsPulled;
        }

        public int playerId { get; }
        public int playerBet { get; }
        public int playerCardsPulled { get; }
    }
}

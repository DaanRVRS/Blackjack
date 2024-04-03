namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij het dealer leerproces.");

            // create player list
            PlayerEntity players = new PlayerEntity(100, 0, "yo");

            // create a deck list
            Deck deck = new Deck();

            //add player named jayro
            players.createPlayerList("Jayro");

            // create the deck with cards
            deck.CreateDeck();

            //foreach (PlayerEntity player in players.getPlayers())
            //{
            //    Console.WriteLine(player);
            //}

            //foreach (Card card in deck.getDeck()) { 
            //    Console.WriteLine(card);
            //}


            //asking for amount of players
            while (players.playerList.Count == 0) {
                string playerAmount = Console.ReadLine();

                if (playerAmount.Equals('1') || playerAmount.Equals('2') || playerAmount.Equals('3'))
                {
                    setPlayers(playerAmount);
                    break;
                }
            }

            // sets players in a list by amount
            void setPlayers (string amount)
            {
            if (amount.Equals('1'))
            {
                //add player named jayro
                players.createPlayerList("Daan");

            }   else if (amount.Equals('2')) {
                //add player named daan
                players.createPlayerList("Daan");
                //add player named jayro
                players.createPlayerList("Jayro");
            }   else if (amount.Equals('3'))
            {
                //add player named daan
                players.createPlayerList("Daan");
                //add player named jayro
                players.createPlayerList("Jayro");
                //add player named bora
                players.createPlayerList("Bora");
            }   

            }
        }
    }
}
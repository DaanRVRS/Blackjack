namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij het dealer leerproces.");

            // create player list
            PlayerEntity players = new PlayerEntity(100, 0, "yo", null);

            // create a deck list
            Deck deck = new Deck();

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
            Console.WriteLine("voer een speler aantal in, 1-3");
            string playerAmount = Console.ReadLine();
            playerAmount = playerAmount.ToString();
            if (playerAmount.Equals("1") || playerAmount.Equals("2") || playerAmount.Equals("3"))
            {
                setPlayers(playerAmount);
            }

            // sets players in a list by amount
            void setPlayers (string amount)
            {
                if (amount.Equals("1"))
                {
                    //add player named jayro
                    players.createPlayerList("Daan");

                }   else if (amount.Equals("2")) {
                    //add player named daan
                    players.createPlayerList("Daan");
                    //add player named jayro
                    players.createPlayerList("Jayro");
                }   else if (amount.Equals("3"))
                {
                    //add player named daan
                    players.createPlayerList("Daan");
                    //add player named jayro
                    players.createPlayerList("Jayro");
                    //add player named bora
                    players.createPlayerList("Bora");
                }   

            }
            foreach (PlayerEntity player in players.getPlayers())
            {
                Console.WriteLine(player);
            }
        }
    }
}
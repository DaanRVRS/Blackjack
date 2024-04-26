using System.Security.Cryptography.X509Certificates;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mistakes = 0;

            void getMistakes()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("TOTAAL AANTAL FOUTEN: " + mistakes);
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!");

                Console.ResetColor();
            }

            Console.WriteLine("Welkom bij het dealer leerproces.");

            // create player list
            PlayerEntity players = new PlayerEntity(100, 0, "yo");
            Dealer dealer = new Dealer();

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
            bool spelersGekozen = false;

            while (!spelersGekozen == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                string playerAmount = Console.ReadLine();
                Console.ResetColor();

                playerAmount = playerAmount.ToString();
                if (playerAmount.Equals("1") || playerAmount.Equals("2") || playerAmount.Equals("3"))
                {
                    setPlayers(playerAmount);
                    spelersGekozen = true;
                } else
                {
                    mistakes++;
                    getMistakes();
                }
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


            // shuffle deck
            Console.WriteLine(" ");
            Console.WriteLine("Dit is het dek");
            foreach (Card card in deck.getDeck()) { 
                Console.WriteLine(card);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Wil je het dek schudden? ja/nee");
            bool answer = false;
            while (!answer == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                string shuffleYesNo = Console.ReadLine();
                Console.ResetColor(); 

                if (shuffleYesNo.ToLower().Equals("ja"))
                {
                    answer = true;
                    deck.ShuffleDeck();
                    Console.WriteLine(" ");
                    Console.WriteLine("Dek is geschud!");
                    //display shuffled deck
                    //foreach (Card card in deck.getDeck())
                    //{
                    //    Console.WriteLine(card);
                    //}
                    startGame();
                } else if (shuffleYesNo.ToLower().Equals("nee"))
                {
                    answer = false;
                    mistakes++;
                    Console.WriteLine("Fout antwoord, +1 fout!");
                    getMistakes();
                } else
                {
                    mistakes++;
                    Console.WriteLine("Fout antwoord, +1 fout!");
                    getMistakes();
                }
            }

            void showPlayers()
            {
                Console.WriteLine("Dit zijn de spelers:");
                foreach (PlayerEntity player in players.getPlayers())
                {
                    Console.WriteLine(player);
                }
            }


            void startGame()
            {
                Console.WriteLine(" ");
                Console.WriteLine("spel start");
                showPlayers();

                for (int i = 1; i <= players.getPlayers().Count; i++)
                {
                    bool deelkeuze = false;

                    while (deelkeuze == false)
                    {
                        Console.WriteLine("Kies een optie voor speler " + i);
                        Console.WriteLine("> Typ 1 om een kaart te geven");
                        Console.WriteLine("> Typ 2 om een kaart af te pakken");
                        Console.WriteLine("> Typ 3 om speler te slaan");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        string antwoord = Console.ReadLine();
                        Console.ResetColor();

                        if (antwoord.Equals("1"))
                        {
                            Console.WriteLine("kaart gegeven");
                            // deal kaart functie aanroepen hier
                            dealer.dealCard(players.getPlayers().ToArray()[i], deck);
                            deelkeuze = true;
                        } else
                        {
                            mistakes++;
                            Console.WriteLine("Fout antwoord, +1 fout!");
                            getMistakes();
                        }
                    }
                }
                RoundLoop(1);
            }

            void RoundLoop(int round)
            {
                bool gameOver = false;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Ronde: " + round);
                Console.WriteLine(" ");

                //players generate answer
                for (int i = 1; i < players.getPlayers().Count; i++)
                {
                    Console.WriteLine(players.getPlayers()[i].getHandTotal());

                    if (players.getPlayers()[i].getHandTotal() <= 10)
                    {
                        Console.WriteLine("less or equal to 10");
                        Console.WriteLine("Hit");
                    } else if (players.getPlayers()[i].getHandTotal() >= 16)
                    {
                        Console.WriteLine("equal to 16 or more");
                        Console.WriteLine("60% stand, 40% hit chance");
                    } else
                    {
                        Console.WriteLine("between 11 & 15");
                        Console.WriteLine("70% hit & 30% stand chance");
                    }
                }
            }

            void end()
            {
                Console.WriteLine("Einde");
            }
        }
    }
}
namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij het dealer leerproces.");

            PlayerEntity player = new PlayerEntity(1, 100, 0);

            Console.Write(player.playerBet);
        }
    }
}
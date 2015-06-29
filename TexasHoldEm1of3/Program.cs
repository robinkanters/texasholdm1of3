namespace TexasHoldEm1of3
{
    using Game;
    using Interfaces;
    using Player;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            IOutputProvider output = new ConsoleOutputProvider();
            ITexasHoldEmGame game = new TexasHoldEmGame(2, 8, output);

            game.AskPlayerCount();
            game.Players.Add(new HumanPlayer(output));
            for (var i = 1; i < game.PlayerCount; i++)
                game.Players.Add(new CpuPlayer(output, i));

            output.WriteLine("");

            game.Dealer.Deal();

            output.WriteLine("");

            game.Dealer.Flop();
            game.Dealer.Turn();
            game.Dealer.River();

            output.WriteLine("");
            output.WriteLine("");

            output.WriteLine("Thank you for playing!");
            output.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}

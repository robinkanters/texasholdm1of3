namespace TexasHoldEm1of3.Game
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TexasHoldEmGame : ITexasHoldEmGame
    {
        public IOutputProvider Output { get; set; }
        public int MinPlayers { get; private set; }
        public int MaxPlayers { get; private set; }
        public List<IPlayer> Players { get; private set; } 
        public int PlayerCount { get; private set; }
        public ICardDealer Dealer { get; private set; }

        public TexasHoldEmGame(int minPlayers, int maxPlayers, IOutputProvider output)
        {
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            Output = output;

            Dealer = new CardDealer(this, Output);
        }

        public async Task AskPlayerCountAsync()
        {
            await Task.Factory.StartNew(AskPlayerCount);
        }

        public void AskPlayerCount()
        {
            int players;

            while (true)
            {
                Output.Write("How many players will be joining? ({0}-{1}): ", MinPlayers, MaxPlayers);

                var answer = Console.ReadLine();

                if (int.TryParse(answer, out players) && players >= MinPlayers && players <= MaxPlayers)
                    break;

                Output.WriteLine("That doesn't look like a number between {0} and {1}, please try again.", MinPlayers, MaxPlayers);
                Output.WriteLine("");
            }

            PlayerCount = players;
            Players = new List<IPlayer>(PlayerCount);
        }

    }
}
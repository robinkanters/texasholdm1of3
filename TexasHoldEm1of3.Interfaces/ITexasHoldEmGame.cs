namespace TexasHoldEm1of3.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITexasHoldEmGame
    {
        int MinPlayers { get; }
        int MaxPlayers { get; }
        int PlayerCount { get; }
        ICardDealer Dealer { get; }
        List<IPlayer> Players { get; } 

        void AskPlayerCount();
        Task AskPlayerCountAsync();
    }
}

namespace TexasHoldEm1of3.Interfaces
{
    using System.Collections.Generic;

    public interface IPlayer
    {
        IList<IPlayingCard> Cards { get; }
        //IOutputProvider Output { get; }
        void PrintHand();
    }
}

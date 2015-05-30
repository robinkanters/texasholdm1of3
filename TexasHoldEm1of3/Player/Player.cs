namespace TexasHoldEm1of3.Player
{
    using System.Collections.Generic;
    using Interfaces;
    
    public abstract class Player : IPlayer
    {
        protected IOutputProvider Output { get; set; }

        protected Player(IOutputProvider outputProvider)
        {
            Cards = new List<IPlayingCard>(2);
            Output = outputProvider;
        }

        public IList<IPlayingCard> Cards { get; private set; }
        public abstract void PrintHand();
    }
}
namespace TexasHoldEm1of3.Game
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CardDealer : ICardDealer
    {
        private static readonly Random Random;
        public ITexasHoldEmGame Game { get; private set; }
        private List<IPlayingCard> DealtCards { get; set; }
        private IOutputProvider Output { get; set; }
        
        public CardDealer(ITexasHoldEmGame game, IOutputProvider output)
        {
            DealtCards = new List<IPlayingCard>();
            Game = game;
            Output = output;
        }

        static CardDealer()
        {
            Random = new Random();
        }

        public void Flop()
        {
            Output.WriteLine("Flop:  {0}, {1}, {2}", NextCard(), NextCard(), NextCard());
        }

        public void Turn()
        {
            Output.WriteLine("Turn:  {0}", NextCard());
        }

        public void River()
        {
            Output.WriteLine("River: {0}", NextCard());
        }

        public void Deal()
        {
            Game.Players.ForEach(p =>
            {
                p.Cards.Add(NextCard());
                p.Cards.Add(NextCard());
                p.PrintHand();
            });
        }

        private IPlayingCard NextCard()
        {
            IPlayingCard card = null;

            // TODO: Optimalize
            while (DealtCards.Count < 52)
            {
                card = new PlayingCard(
                    NextRandom<Suit>(),
                    NextRandom<Rank>()
                );

                if (DealtCards.Count(c => c.Rank == card.Rank && c.Suit == card.Suit) > 0)
                    continue;

                DealtCards.Add(card);
                break;
            }

            return card;
        }

        private static T NextRandom<T>()
        {
            var values = Enum.GetValues(typeof(T));
            return (T) values.GetValue(Random.Next(values.Length));
        }
    }
}

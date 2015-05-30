namespace TexasHoldEm1of3.Game
{
    using System;
    using Interfaces;

    public class PlayingCard : IPlayingCard
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }

        public PlayingCard(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            var suitSign = ToSuitSign(Suit);
            var rankSign = ToRankSign(Rank);
            return string.Format("{0}{1}", suitSign, rankSign);
        }

        private static string ToRankSign(Rank rank)
        {
            switch (rank)
            {
                case Rank.Ace:
                    return "A";
                case Rank.Two:
                    return "2";
                case Rank.Three:
                    return "3";
                case Rank.Four:
                    return "4";
                case Rank.Five:
                    return "5";
                case Rank.Six:
                    return "6";
                case Rank.Seven:
                    return "7";
                case Rank.Eight:
                    return "8";
                case Rank.Nine:
                    return "9";
                case Rank.Ten:
                    return "10";
                case Rank.Jack:
                    return "J";
                case Rank.Queen:
                    return "Q";
                case Rank.King:
                    return "K";
                default:
                    throw new ArgumentException("Invalid rank");
            }
        }

        private static char ToSuitSign(Suit suit)
        {
            switch (suit)
            {
                case Suit.Spades:
                    return (char)9824;
                case Suit.Clubs:
                    return (char)9827;
                case Suit.Hearts:
                    return (char)9829;
                case Suit.Diamonds:
                    return (char)9830;
                default:
                    throw new ArgumentException("Invalid suit");
            }
        }
    }
}
namespace TexasHoldEm1of3.Player
{
    using Interfaces;

    public class HumanPlayer : Player
    {
        public override void PrintHand()
        {
            Output.WriteLine("Your hand:  {0}, {1}", Cards[0], Cards[1]);
        }

        public HumanPlayer(IOutputProvider outputProvider) : base(outputProvider)
        {
        }
    }
}
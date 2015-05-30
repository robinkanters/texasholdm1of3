namespace TexasHoldEm1of3.Player
{
    using Interfaces;

    public class CpuPlayer : Player
    {
        public int CpuNum { get; private set; }

        public override void PrintHand()
        {
            Output.WriteLine("CPU {0} hand: {1}, {2}", CpuNum, Cards[0], Cards[1]);
        }

        public CpuPlayer(IOutputProvider outputProvider, int num) : base(outputProvider)
        {
            CpuNum = num;
        }
    }
}
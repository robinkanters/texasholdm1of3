namespace TexasHoldEm1of3.Interfaces
{
    public interface ICardDealer
    {
        ITexasHoldEmGame Game { get; }

        void Flop();
        void Turn();
        void River();

        void Deal();
    }
}

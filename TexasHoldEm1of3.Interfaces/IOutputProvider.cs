namespace TexasHoldEm1of3.Interfaces
{
    public interface IOutputProvider
    {
        void Write(string outputString);
        void Write(string format, params object[] arguments);
        void WriteLine(string outputString);
        void WriteLine(string format, params object[] arguments);
    }
}

namespace TexasHoldEm1of3
{
    using System;
    using Interfaces;

    internal class ConsoleOutputProvider : IOutputProvider
    {
        public void Write(string outputString)
        {
            Console.Write(outputString);
        }

        public void Write(string format, params object[] arguments)
        {
            Write(string.Format(format, arguments));
        }

        public void WriteLine(string outputString)
        {
            Console.WriteLine(outputString);
        }

        public void WriteLine(string format, params object[] arguments)
        {
            WriteLine(string.Format(format, arguments));
        }
    }
}
using System;
using System.Threading;

namespace RonAndKanye
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                quoteGenerator.GetKanyeQuote();
                Thread.Sleep(500);
                quoteGenerator.GetRonQuote();
                Thread.Sleep(500);
                Console.WriteLine();
            }
        }
    }
}

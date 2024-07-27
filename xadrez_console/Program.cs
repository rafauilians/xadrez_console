using System;
using tabuleiro;
using xadrez;

namespace xadrez_console 
{
    class program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.ReadLine();
        }
    }
}
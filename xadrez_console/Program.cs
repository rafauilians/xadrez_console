﻿using System;
using tabuleiro;

namespace xadrez_console 
{
    class program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("posição: "+ P);

            Console.ReadLine();
        }
    }
}
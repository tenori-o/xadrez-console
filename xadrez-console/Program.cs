using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Posicao P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
            Console.ReadLine();
        }
    }
}

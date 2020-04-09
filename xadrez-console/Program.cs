using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.AdicionarPeca(new Rei(tab, Cor.PRETO), new Posicao(0, 0));
            tab.AdicionarPeca(new Bispo(tab, Cor.PRETO), new Posicao(1, 3));
            tab.AdicionarPeca(new Cavalo(tab, Cor.PRETO), new Posicao(2, 6));

            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}

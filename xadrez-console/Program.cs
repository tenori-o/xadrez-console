using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.AdicionarPeca(new Rei(tab, Cor.PRETO), new Posicao(0, 0));
                tab.AdicionarPeca(new Bispo(tab, Cor.PRETO), new Posicao(0, 1));
                tab.AdicionarPeca(new Cavalo(tab, Cor.PRETO), new Posicao(2, 6));

                tab.AdicionarPeca(new Rainha(tab, Cor.BRANCO), new Posicao(3, 5));
                tab.AdicionarPeca(new Peao(tab, Cor.BRANCO), new Posicao(7, 3));
                tab.AdicionarPeca(new Torre(tab, Cor.BRANCO), new Posicao(4, 6));

                Tela.ImprimirTabuleiro(tab);

            }
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
			}
                Console.ReadLine();
        }
    }
}

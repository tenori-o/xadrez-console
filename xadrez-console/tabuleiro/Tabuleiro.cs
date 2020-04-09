using System;
using tabuleiro.Exceptions;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;

            _pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(Posicao pos)
        {
            return _pecas[pos.Linha, pos.Coluna];
        }

        public void AdicionarPeca(Peca peca, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição");
            }
            _pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        private bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha > Linhas || pos.Coluna < 0 || pos.Coluna > Colunas)
            {
                return false;
            }
            return true;
        }

        private void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida");
            }
        }
    }
}

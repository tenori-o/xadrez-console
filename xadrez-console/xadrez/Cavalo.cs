using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "C";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // NorthWest
            pos.SetPosicao(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            // WestNorth
            pos.SetPosicao(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }

            // NorthEast
            pos.SetPosicao(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            // EastNorth
            pos.SetPosicao(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }

            // SouthEast
            pos.SetPosicao(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            // EastSouth
            pos.SetPosicao(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }

            // SouthWest
            pos.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            // WestSouth
            pos.SetPosicao(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }

            return matriz;
        }

    }
}

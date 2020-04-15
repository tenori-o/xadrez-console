using tabuleiro;

namespace xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "D";
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // North
            pos.SetPosicao(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            // South
            pos.SetPosicao(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            // East
            pos.SetPosicao(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            // West
            pos.SetPosicao(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            // NorthWest
            pos.SetPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.SetPosicao(pos.Linha - 1, pos.Coluna - 1);
            }

            // NorthEast
            pos.SetPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.SetPosicao(pos.Linha - 1, pos.Coluna + 1);
            }

            // SouthEast
            pos.SetPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.SetPosicao(pos.Linha + 1, pos.Coluna + 1);
            }

            // SouthWest
            pos.SetPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.SetPosicao(pos.Linha + 1, pos.Coluna - 1);
            }

            return matriz;
        }

    }
}

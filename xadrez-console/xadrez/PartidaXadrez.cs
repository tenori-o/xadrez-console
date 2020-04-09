using tabuleiro;

namespace xadrez
{
    class PartidaXadrez
    {
        private int _turno;
        private Cor _jogadorAtual;

        public Tabuleiro Tab { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.BRANCO;
            Terminada = false;

            ColocarPecas();
        }

        private void ColocarPecas()
        {
            Tab.AdicionarPeca(new Torre(Tab, Cor.BRANCO), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.AdicionarPeca(new Bispo(Tab, Cor.BRANCO), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.AdicionarPeca(new Rainha(Tab, Cor.BRANCO), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.AdicionarPeca(new Torre(Tab, Cor.BRANCO), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.AdicionarPeca(new Rei(Tab, Cor.BRANCO), new PosicaoXadrez('e', 2).ToPosicao());
            Tab.AdicionarPeca(new Peao(Tab, Cor.BRANCO), new PosicaoXadrez('d', 1).ToPosicao());

            Tab.AdicionarPeca(new Torre(Tab, Cor.PRETO), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.AdicionarPeca(new Bispo(Tab, Cor.PRETO), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.AdicionarPeca(new Rainha(Tab, Cor.PRETO), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.AdicionarPeca(new Torre(Tab, Cor.PRETO), new PosicaoXadrez('e', 7).ToPosicao());
            Tab.AdicionarPeca(new Rei(Tab, Cor.PRETO), new PosicaoXadrez('e', 8).ToPosicao());
            Tab.AdicionarPeca(new Peao(Tab, Cor.PRETO), new PosicaoXadrez('d', 8).ToPosicao());
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RemoverPeca(origem);
            p.IncrementarQntMovimentos();

            Peca pecaCapturada = Tab.RemoverPeca(destino);
            Tab.AdicionarPeca(p, destino);
        }
    }
}

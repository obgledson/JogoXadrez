using System;
using tabuleiro;
namespace xadrez
{
    class PartidadeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }


        public PartidadeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 3));
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 6));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 7));
        }
    }
}

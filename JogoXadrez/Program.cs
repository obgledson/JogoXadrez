using System;
using tabuleiro;
using xadrez;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 3));
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 6));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 7));
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}

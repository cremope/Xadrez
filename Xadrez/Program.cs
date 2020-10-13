using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            //Console.WriteLine(pos);

            //Console.WriteLine(pos.toPosicao());
            //Console.ReadLine();

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
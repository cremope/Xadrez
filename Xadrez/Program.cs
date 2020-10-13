using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                //Console.WriteLine(pos);

                //Console.WriteLine(pos.toPosicao());
                //Console.ReadLine();

                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                //tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);

                }

                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); ;
            }

            Console.ReadLine();

        }
    }
}
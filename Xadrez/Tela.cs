using System;
using tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; i < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.WriteLine("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
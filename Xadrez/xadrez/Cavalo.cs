﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            posicao.definirValores(posicao.linha - 1, posicao.coluna - 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha - 2, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha - 2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha - 1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 1, posicao.coluna + 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 2, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }

            posicao.definirValores(posicao.linha + 1, posicao.coluna - 2);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[posicao.linha, posicao.coluna] = true;
            }


            return mat;
        }
    }
}

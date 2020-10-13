using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor) //base significa que estou usando o construtor da classe Peca
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}

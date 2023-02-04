using JogoDeXadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.xadrez
{
    public class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro? tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}

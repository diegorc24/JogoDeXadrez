using JogoDeXadrez.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.xadrez
{
    public class PartindaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartindaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada= false;
            colocarPecas();
        }
      

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tabuleiro.retirarPeca(origem);
            peca.incremnetarQteMovimentos();
            Peca pecaCapturada = tabuleiro.retirarPeca(destino);
            tabuleiro.colacarPeca(peca, destino);
        }

        private void colocarPecas()
        {
            tabuleiro.colacarPeca(new Torre(Cor.Preta, tabuleiro), new PosicaoXadrez('c', 1).ToPosicao());
          
        }
    }
}

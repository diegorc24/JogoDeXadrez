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
        private Tabuleiro tabuleiro;
        private int turno;
        private Cor JogadorAtual;

        public PartindaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8,8);
            turno = 1;
            JogadorAtual = Cor.Branca;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) 
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }

        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        public void colacarPeca(Peca peca, Posicao posicao)
        {
            if (existePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public bool posicaoValida(Posicao posicao) 
        {
            if (posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas)
            {
                return false;
            }

            return true;
        }

        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}

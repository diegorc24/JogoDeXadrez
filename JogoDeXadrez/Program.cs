using JogoDeXadrez.tabuleiro;
using JogoDeXadrez.xadrez;

namespace JogoDeXadrez
{
   public class Program
   {
        static void Main(string[] args) 
        {
            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);
            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.ToPosicao());
            //try
            //{
            //    Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            //    tabuleiro.colacarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
            //    tabuleiro.colacarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 9));
            //    tabuleiro.colacarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(0, 2));

            //    Tela.imprimirTabuleiro(tabuleiro);
            //}
            //catch(TabuleiroException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
          
            
        }
    }
}

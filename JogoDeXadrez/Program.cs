using JogoDeXadrez.tabuleiro;
using JogoDeXadrez.xadrez;
using System.Security.Cryptography.X509Certificates;

namespace JogoDeXadrez
{
   public class Program
   {
        static void Main(string[] args) 
        {
            //PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);
            //Console.WriteLine(posicaoXadrez);
            //Console.WriteLine(posicaoXadrez.ToPosicao());
            try
            {
                PartindaDeXadrez partindaDeXadrez = new PartindaDeXadrez();

                while (!partindaDeXadrez.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partindaDeXadrez.tabuleiro);

                    Console.WriteLine();
                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partindaDeXadrez.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}

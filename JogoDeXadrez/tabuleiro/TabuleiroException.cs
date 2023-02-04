using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.tabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string mensage) : base(mensage) 
        { 

        }
    }
}

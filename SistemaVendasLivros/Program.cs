using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class Program
    {
        static void Main(string[] args)
        {
            control controle = new control();
            controle.Operacao();

            Console.ReadLine();//Manter o Prompt Aberto
        }//fim do método main
    }//fim da classe
}//fim do projeto

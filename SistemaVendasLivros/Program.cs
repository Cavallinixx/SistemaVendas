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
            controlLogin controle = new controlLogin();
            controlLivro controleLivro = new controlLivro();
            controlEstoque controleEstoque = new controlEstoque();
            controlReserva controlReserva = new controlReserva();
            
            controle.OperacaoMenu();

            Console.ReadLine();//Manter o Prompt Aberto
        }//fim do método main
    }//fim da classe

    
}//fim do projeto

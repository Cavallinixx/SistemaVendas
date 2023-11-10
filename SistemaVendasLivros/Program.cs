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
            
            Menu_Principal controle = new Menu_Principal();
            controlUsuario controleLogin = new controlUsuario();
            control_Livro controleLivro = new control_Livro();
            controlEstoque controleEstoque = new controlEstoque();
            controlReserva controlReserva = new controlReserva();
            Menu_Principal UsuarioUm = new  Menu_Principal();
            Menu_Principal senhaUm = new Menu_Principal();
            Menu_Principal MenuLivro = new Menu_Principal();

            
            controle.Operacao();


            Console.ReadLine();//Manter o Prompt Aberto
        }//fim do método main
    }//fim da classe

    
}//fim do projeto

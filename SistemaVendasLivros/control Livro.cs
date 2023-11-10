using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class control_Livro
    {
        double ValorLivro1;
        double ValorLivro2;
        double ValorLivro3;
        int livro1;
        int livro2;
        int livro3;
        double opcao;
        


        public control_Livro()
        {
            livro1 = new int();
            livro2 = new int();
            livro3 = new int();
            ValorLivro1 = livro1;
            ValorLivro2 = livro2;
            ValorLivro3 = livro3;
            ValorLivro1 = 10;
            ValorLivro2 = 15;
            ValorLivro3 = 5;
            control_Livro Escolha = new Menu_Principal();

        }// fim do model 

        public void Escolha()
        {

            Console.WriteLine(" Escolha o livro desejado " );
             opcao = Convert.ToInt32(Console.ReadLine());

        }

    
    }// fim da classe
}// fim projeto 

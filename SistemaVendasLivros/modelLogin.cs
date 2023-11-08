using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class model
    {
        public double pessoas;
        public int[] cadastro;
        public double cadastroNovo;
        public double livros;
        public double reserva;
        public double estoque;
        public int i;
        public int[] vetor;


        public model()
        {
            pessoas = new double();
            cadastro = new int[10];
            livros = new double();
            reserva = new double();
            estoque = new double();
            cadastroNovo = new double();
            i = 0;
            vetor = new int[10];
            cadastroNovo = 0;
            ConsultarLogin = 0; ;



        }//fim do construtor

        public double ConsultarLogin
        {
            get { return pessoas; }
            set { this.pessoas = value; }
        }//fim do get set

        //Entrar login

        public double Preecher()
        {
            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + " Digite seu login: ");
                    cadastro[i] = Convert.ToInt32(Console.ReadLine());
                    if ((cadastro[i] < 0) || (cadastro[i] > 10))
                    {
                        Console.WriteLine(" NÃO ENCONTRADO! FAÇA SEU CADASTRO... ");
                    }//fim da validação
                } while ((cadastro[i] < 0) || (cadastro[i] > 10));
                ConsultarLogin += cadastro[i];
            }//fim do for
            return ConsultarLogin / i;
        }//fim método

    }// fim da classe 
}//fim projeto 

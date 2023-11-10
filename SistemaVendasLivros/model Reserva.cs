using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class model_Reserva
    {
        public int i;
        public int[] vetor;
        double opcao;

        public model_Reserva()
        {

            i = 0;
            vetor = new int[10];
            opcao = new double();
        }// fim model

        public void Reserva() 
        {
            Console.WriteLine(" Indisponivel! Gostaria de realizar a reserva: \n +" +
                                                            "0. Sim  \n" +
                                                            "1. Não" );
            opcao= Convert.ToDouble( Console.ReadLine() );
        }//fim
        public void Compra() 
        {
            Console.WriteLine(" Reserva Realizada! Finalizar compra? \n +" +
                                                            "0. Sim  \n" +
                                                            "1. Não");
            opcao = Convert.ToDouble( Console.ReadLine() );
            
            if ( opcao > 0 ) 
            Console.WriteLine("");
            
        }
    }//fim 
}//fim

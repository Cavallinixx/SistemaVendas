using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class modelUsuario
    {
        public double pessoas;
        public double reserva;
        public double estoque;
        public double cadastro;
        public int i;
        public int[] vetor;
        public string login2;
        public string senha2;


        public modelUsuario()
        {
            pessoas = new double();
            reserva = new double();
            estoque = new double();
            cadastro = new double();
            i = 0;
            vetor = new int[10];
            login2 = "nois";
            senha2 = "123";
            
            
            
            
        }// fim do model 

        public Boolean ValidarUsuario(string senhaUm, string usuarioUm) 
        {
            if ((usuarioUm == login2) || (senhaUm == senha2))
            { 
                return true;
            }
            else 
            { 
                return false;
            }
        }// fim validação 
    }// fim da classe 
}//fim projeto 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class Menu_Principal
    {
        model modelo;
        private int opcao;
        public controlLogin()
        {
            modelo = new model();//Criando uma chave
            ConsultarOpcao = -1;
        }//fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }//fim do método
        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Sair\n" +
                              "1. Digite seu login: \n" +
                              "2. Cadastro\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void OperacaoMenu()
        {
            do
            {
                Menu();//Mostrar o menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ConsultarLogin());
                        break;
                    default:
                        Console.WriteLine("Erro, escolha uma opção valida!");
                        break;
                }//fim do switch
            } while (ConsultarOpcao != 0);
        }//fim do método operacao

    }
}

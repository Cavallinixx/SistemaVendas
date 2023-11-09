using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLivros
{
    class Menu_Principal
    {
        modelUsuario modelo;
        private int opcao;

        public Menu_Principal()
        {
            this.modelo = new modelUsuario();//Criando uma chave
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

        public void MenuLivro()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Sair \n" +
                              "1. Voar \n" +
                              "2. Pular\n" +
                              "3. Sair\n" +
                              "4. Voar \n" +
                              "5. Sorrir\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
            {
                double cadastro;
                double usuarioUm;
                double senhaUm;
              
                do
                {
                    Menu();//Mostrar o menu em tela
                    Console.Clear();
                    switch (ConsultarOpcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;
                        case 1:
                        Console.WriteLine("Digite seu login: ");
                        string login = Convert.ToString(Console.ReadLine());

                        Console.WriteLine(" Digite sua senha: ");
                        string senha = Convert.ToString(Console.ReadLine());

                        if (this.modelo.ValidarUsuario(senha, login) == false)
                        {
                            Console.WriteLine(" DADOS INCORRETOS!! Refaça seu cadastro: \n"); 


                        }
                        else
                        
                        {
                            Console.WriteLine(" Bem vindo ao Menu, escolha o livro desejado: ");
                            Console.WriteLine()

                        }
                            break;
                        default:
                            Console.WriteLine("Erro, escolha uma opção valida!");
                            break;
                    }//fim do switch
                } while (ConsultarOpcao != 0);
            }//fim do método operacao

        }
    }

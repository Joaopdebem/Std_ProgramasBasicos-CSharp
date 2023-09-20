using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace usoEnum
{
    public class Program
    {
        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main()
        {
            Console.WriteLine("Selecione uma das opções abaixo: \n");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar\n");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("\nVocê quer criar algo\n");
                    NovaEscolha();
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("\nVocê quer deletar algo\n");
                    NovaEscolha();
                    break;
                case Opcao.Editar:
                    Console.WriteLine("\nVocê quer editar algo\n");
                    NovaEscolha();
                    break;
                case Opcao.Listar:
                    Console.WriteLine("\nVocê quer listar algo\n");
                    NovaEscolha();
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("\nVocê quer atualizar algo\n");
                    NovaEscolha();
                    break;
                default:
                    Console.WriteLine("\n************** Opção inválida. Tente novamente!************** \n");
                    Main();
                    break;
            }

        }

        static void NovaEscolha()
        {
            Console.WriteLine("\nDeseja escolher uma outra opção?\n");
            Console.WriteLine("1-Sim\n2-Não\n");
            int novaEscolha = int.Parse(Console.ReadLine());

            if (novaEscolha == 1)
            {
                Console.WriteLine("");
                Main();
            }
            else if (novaEscolha == 2)
            {
                Console.WriteLine("\nCerto. Estamos encerrando seu programa.\n");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\n************** Opção inválida. Tente novamente! **************\n");
                NovaEscolha();
            }
        }

    }
}

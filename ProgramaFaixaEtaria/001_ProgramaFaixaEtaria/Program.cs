using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_ProgramaFaixaEtaria
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Qual sua idade? ");

            int idade = int.Parse(Console.ReadLine());

            Program programaIdade = new Program();
            programaIdade.FaixaEtaria(idade);
            Program programaContinuar = new Program();
            programaContinuar.Continuar(idade);

        }

        public void FaixaEtaria(int idade)
        {
            if (idade < 20 && idade > 0)
            {
                if (idade == 1)
                {
                    Console.WriteLine($"\nCom {idade} ano de idade, você pertence ao grupo de indivíduos Jovens.");
                }
                else
                {
                    Console.WriteLine($"\nCom {idade} anos, você pertence ao grupo de indivíduos Jovens.");
                }

            }
            else if (idade >= 20 && idade < 60)
            {
                Console.WriteLine($"\nVocê tem {idade} anos, já pertence ao grupo de indivíduos Adultos");
            }
            else if (idade >= 60 && idade < 110)
            {
                Console.WriteLine($"\nCom seus incríveis {idade} anos, você pertence ao grupo de indivíduos Idosos");
            }
            else if (idade > 110 && idade < 130)
            {
                Console.WriteLine($"\nNo auge dos seus {idade} anos você já se tornou uma relíquia em nossa história.");
            }
            else
            {
                Console.WriteLine("\nVocê inseriu uma idade inválida. Tente novamente!\n");
                Main();
            }

        }

        public void Continuar(int continuar)
        {
            Console.WriteLine("\n\nDeseja tentar uma outra idade?\n" + "[Digite 1 - Sim]\n" + "[Digite 2 - Não]\n");

            continuar = int.Parse(Console.ReadLine());

            if (continuar == 1)
            {
                Console.WriteLine("");
                Main();
            }
            else if (continuar == 2)
            {
                Console.WriteLine("\n*-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-**-*\n");
                Console.WriteLine("Programa encerrando em\n");
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente!");
                Continuar(continuar);
            }

        }


    }

}

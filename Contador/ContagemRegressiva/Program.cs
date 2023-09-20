using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemRegressiva
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Contador");

            public void Contagem(int i)
            {

                Console.WriteLine("Vamos iniciar uma contagem.");

                for (; i > 0; i--)
                {
                    Console.WriteLine($"{i}");
                }
            }

            Contagem(10);

            Console.WriteLine("Deseja fazer outra contagem? [1-SIM/2-NÃO]");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Iremos iniciar em seguida uma nova contagem");
            }
            else
            {
                Console.WriteLine("Solicitação encerrada");
            }

            Console.ReadLine();

        }
    }
}

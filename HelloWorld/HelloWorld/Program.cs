using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine("My old friend");

            int[] despesas = new int[4] {1200, 1500, 900, 400};
            int[] receitas = new int[2] {3400, 210};

            int somarDespesas = despesas.Sum();
            int somarReceitas = receitas.Sum();
            int saldo = somarReceitas - somarDespesas;

            while(saldo < 0)
            {
                saldo += 50;
                Console.WriteLine($"{saldo}");
            }

            Console.WriteLine(somarDespesas);
            Console.WriteLine(somarReceitas);
            Console.WriteLine(saldo);

            Console.ReadLine();

        }
    }
}

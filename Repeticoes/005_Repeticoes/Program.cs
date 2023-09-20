using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Repeticoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string[] palavras = { "Joao", "Pedro", "De", "Bem", "da", "Rosa" };


            // while(){} - Execute enquanto for verdade
            while (contador < 10)
            {
                Console.WriteLine("Executa enquanto for verdade - " + contador);
                contador++;
            }

            // do{}while() - Execute ao menos 1 vez menos sendo mentira 
            do 
            {
                Console.WriteLine("\nExecutar pelo menos uma vez mesmo sendo mentira\n");
            }
            while (1000 == 10);


            // foreach(){} - Para cada palavra no array, repita 
            foreach (string palavra in palavras) 
            {
                Console.WriteLine("foreach rodando - " + palavra);
            }


            Console.WriteLine("");
            for(int novoContador = 0; novoContador < palavras.Length; novoContador++)
            {
                Console.WriteLine("for rodando em crescente - " + palavras[novoContador]); 
                
            }


            Console.WriteLine("");
            for (int novoContador2 = palavras.Length - 1 ; novoContador2 >= 0;  novoContador2--) 
            {
                Console.WriteLine("for rodando em decrescente - " + palavras[novoContador2]);
            }



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_AlgoritmoPrecoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1.declarar as variaveis

            double precoInicial, precoFinal, taxa;
            string nome;

            // 2.Pedir valores
            Console.Write("Nome: ");
                nome = Console.ReadLine();

            Console.Write("\n Valor inicial: ");
            precoInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Taxa de desconto: ");
            taxa = Convert.ToDouble(Console.ReadLine());

            //3. Processar os valores

            precoFinal = precoInicial-(precoInicial * (taxa / 100));


            // TODO ZP: Temos de melhorar esta concatenação
            /* v1
            Console.WriteLine("O preço final de" + nome + " é " + precoFinal);
            // v2
            Console.WriteLine("O preço final de" + nome + " é " + Convert.ToString(precoFinal));
            // v3
            */

            Console.WriteLine(" \n \n \n O preço final de" + nome + " é " + precoFinal.ToString());




        }
    }
}

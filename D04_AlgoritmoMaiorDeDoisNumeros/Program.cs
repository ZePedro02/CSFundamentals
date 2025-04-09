using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_AlgoritmoMaiorDeDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Declarar variáveis

            double numero1, numero2;

            Console.Write("---------------------------------");
            Console.Write("\nAlgoritmo 'Maior de 2 números'");
            Console.Write("\n---------------------------------");


            Console.Write("\n\n\n\nNúmero1 : ");
            numero1 = Convert.ToDouble( Console.ReadLine());

            Console.Write("\nNúmero2 : ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            /*
             * 
             * ----------- v1
            if (numero1 > numero2) 
            {
                Console.WriteLine("\n\n\nO número maior é " + numero1);
            }
            if (numero1 < numero2) 
            {
                Console.WriteLine("\n\n\nO número maior é " + numero2);
            }
            if (numero1 == numero2) 
            {
                Console.WriteLine("\n\n\nO número1 é igual ao número2.");
            }
            */

            /*
             * ------------ v2
             * 
            if (numero1 > numero2)
            {
                Console.WriteLine("\n\n\nO número1 é maior");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("\n\n\nO número2 é maior");
            }
            else
            {
                Console.WriteLine("\n\n\nO número1 é igual ao número2.");
            }
            */

            compute(numero1, numero2);
            Console.ReadKey();
        }
        public static int compute(double a, double b)
        {
            if (a > b)
            { 
                Console.WriteLine("\n\n\nO número1 é maior");
                return 0;
            }

            if (a < b)
            {
                Console.WriteLine("\n\n\nO número2 é maior");
            return 0;
            }
            Console.WriteLine("\n\n\nO número1 é igual ao número2.");
            return 0;
        }
    }

}

/*
 Criar uma calculadora com as 4 operações aritméticas
 
Funcionalidades:
Apresentar menu com 4 operações: 4 com as operações
 Pedir 2 valores e a operação a executar
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace E01_Calculadora_v01_SemClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.WriteTitle("               Calculadora XPTO", "");

            string operacao;
            string operacao01;
            double numero01, numero02, resultado;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Que operação pretende fazer?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    'a' - Adição");
            Console.WriteLine("    's' - Subtração");
            Console.WriteLine("    'm' - Multiplicação");
            Console.WriteLine("    'd' - Divisão");
            operacao = Console.ReadLine();
            #region Multiplicação
                if (operacao == "m")
            {
                Console.WriteLine("Insira o primeiro número");
                numero01 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número");
                numero02 = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\nO resultado da multiplicação é {numero01 * numero02}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            #endregion

            #region Divisão
            else if (operacao =="d")
            {
                Console.WriteLine("Insira o primeiro número");
                numero01 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número");
                numero02 = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\nO resultado da divisão é {numero01 / numero02}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            #endregion

            #region Adição
            else if (operacao ==("a"))
            {
                Console.WriteLine("Insira o primeiro número");
                numero01 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número");
                numero02 = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\nO resultado da adição é {numero01 + numero02}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            #endregion

            #region Subtração

            else if (operacao == "s")
            {
                Console.WriteLine("Insira o primeiro número");
                numero01 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o segundo número");
                numero02 = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\nO resultado da subtração é {numero01 - numero02}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            #endregion
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nNão escolheu nenhuma operação");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Utility.terminateConsole();
        }
    }
}

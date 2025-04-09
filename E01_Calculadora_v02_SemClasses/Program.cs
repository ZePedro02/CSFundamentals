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
namespace E01_Calculadora_v02_SemClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.setUniCode();
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
                if(operacao == "m")                                                 //Operação é multiplicação
                {
                    Console.Write("\nInsira o primeiro número: ");
                     
                    if(!Double.TryParse(Console.ReadLine(), out numero01))          //Se não der para converter o 1º num
                        Console.WriteLine("Número inválido!");  

                    else                                                            //Se conseguir converter
                    {
                        Console.Write("\nInsira o segundo número: ");               // Se não der para conveter o 2º num
                        
                        if(!Double.TryParse(Console.ReadLine(), out numero02))
                            Console.WriteLine("Número inválido!");
                          
                        else                                                        //Se ambos foram  conversíveis
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\nO resultado da multiplicação é {numero01 * numero02}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                
            #endregion

            #region Divisão
            else if (operacao =="d")
            {
                    Console.Write("\nInsira o primeiro número: ");

                    if (!Double.TryParse(Console.ReadLine(), out numero01))
                        Console.WriteLine("Número inválido!");

                    else
                    {
                        Console.Write("\nInsira o segundo número: ");

                    if (!Double.TryParse(Console.ReadLine(), out numero02))
                        Console.WriteLine("Número inválido!");
                    else if (numero02 == 0)
                        Console.WriteLine("\nO Segundo número não pode ser 0!");
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n\nO resultado da divisão é {numero01 / numero02}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    }

            }
            #endregion

            #region Adição
            else if (operacao ==("a"))
            {
                {
                    Console.Write("\nInsira o primeiro número: ");

                    if (!Double.TryParse(Console.ReadLine(), out numero01))
                        Console.WriteLine("Número inválido!");

                    else
                    {
                        Console.Write("\nInsira o segundo número: ");

                        if (!Double.TryParse(Console.ReadLine(), out numero02))
                            Console.WriteLine("Número inválido!");

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\nO resultado da adição é {numero01 + numero02}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }

            }
            #endregion

            #region Subtração

            else if (operacao == "s")
            {
                    Console.Write("\nInsira o primeiro número: ");

                    if (!Double.TryParse(Console.ReadLine(), out numero01))
                        Console.WriteLine("Número inválido!");

                    else
                    {
                        Console.Write("\nInsira o segundo número: ");

                        if (!Double.TryParse(Console.ReadLine(), out numero02))
                            Console.WriteLine("Número inválido!");

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\nO resultado da subtração é {numero01 - numero02}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                
            }
            #endregion
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nOpção inválida");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Utility.terminateConsole();
        }
    }
}

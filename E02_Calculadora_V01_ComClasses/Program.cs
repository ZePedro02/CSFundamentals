using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E02_Calculadora_V01_ComClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Mostrar o menu
            Calculadora.MostrarMenu();

            //Selecionar opção
            int escolha = 7;
            string op = string.Empty;
            do
            {
                Utility.WriteMessage("Selecione a opção que pretende: ","\n\n");
                escolha = Convert.ToInt16(Console.ReadLine());
                op= Calculadora.GetOperator(escolha);
            } while ( op ==string.Empty);
            
            //Input do valor 1
            double val1 = Calculadora.InputValido("\nValor 1: ");

            //input do valor 2
            double val2 = Calculadora.InputValido("\nValor 2: ");

            //Criar construtor com os inputs
            Calculadora calculadora01 = new Calculadora(val1, val2, op);

            //calcular o resultado
            double result01 = calculadora01.Calcular(op);

            //Mostrar p resultado
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utility.WriteMessage($"Result: {val1}{op}{val2}={result01}");
            Console.ForegroundColor = ConsoleColor.White;

            Utility.terminateConsole();
        }
    }
}

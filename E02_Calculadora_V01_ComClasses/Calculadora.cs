using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;




namespace E02_Calculadora_V01_ComClasses
{
    internal class Calculadora
    {
        #region Properties
        private double Val1 { get; set; }
        private double Val2 { get; set; }

        private double Result { get; set; }

        private string Op { get; set; }
        #endregion

        #region Constructors

        public Calculadora()
        {
            Val1 = 0;
            Val2 = 0;
            Result = 0;
            Op = string.Empty;
        }

        public Calculadora(double val1, double val2, string op)
        {
            Val1 = val1;
            Val2 = val2;
            Result = Calcular(Op);
            Op = op;
        }


        #endregion


        public double Calcular (string op)
        {

            switch (op)
            {
                case "+":
                    Result = Val1 + Val2;
                    break;
                case "-":
                    Result = Val1 - Val2;
                    break;
                case "*":
                    Result = Val1 * Val2;
                    break;
                case "/":
                    Result = Val1 / Val2;
                    break;

            }

            return Result;

        }

        public static void MostrarMenu()
        {
            string[,] menu =
            {
                { "0",". Sair" },
                { "1",". Soma" },
                { "2",". Subtração" },
                { "3",". Multiplicação" },
                { "4",". Divisão" }
            };
            Utility.WriteTitle("Calculadora", "");
           for (int r = 0; r < menu.GetLength(0); r++)
           {
                for (int c = 0; c < menu.GetLength(1); c++) 
                {
                    Utility.WriteMessage($"{menu[r,c]}"); 
                }
                Console.WriteLine();
           }
        }


        public static string GetOperator (int op)
        {
            string opeq = string.Empty;
            switch (op)
            {
                case 1:
                    opeq = "+";
                    break;
                case 2:
                    opeq = "-";
                    break;
                case 3:
                    opeq = "*";
                    break;   
                case 4:
                    opeq = "/";
                    break;
                default:
                    Utility.WriteErrorMessage("Opção inválida!","\n");
                    break;
            }
            return opeq;
        }
        public static double InputValido(string message)
        {
            while (true)
            {
                Utility.WriteMessage(message);
                if (double.TryParse(Console.ReadLine(), out double result))
                { return result; }
                Utility.WriteErrorMessage("Valor inválido!","\n");
            }    
        
        }

    }
}

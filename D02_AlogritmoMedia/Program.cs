using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_AlogritmoMedia

{
    class Program
    {

        static void Main(string[] args)
        {
            #region Valores fixos
            /*
             //1. Declarar as variávies

            int number01, number02;
             double result;

             //2. Atribuir valores

             number01 = 10;
             number02 = 5;


             //3. Processar os dados

             result = (number01 + number02) / 2;

             Console.WriteLine(result);
             Console.ReadKey();
            */
            #endregion

            #region V2 pedir números ao user
            /*
            //1. Declarar as variáveis

            String number01 = "";
            int number02 = 0;
            double result = 0;

            //2. Pedir o 1º valor ao user 
            Console.Write("Número 1: ");
            number01 = Console.ReadLine();    // Tornei a variável string

            //3. Pedir o 2º valor ao user 
            Console.Write("Número 2: ");
            // number02 = Console.ReadLine();    // Converter o que vem da consola em int
            number02 = Convert.ToInt16(Console.ReadLine());

            // 2. Processamento

            // 3.Calcular a média

            result = (Convert.ToInt16(number01) + number02) / 2;

            Console.WriteLine("A média é: ");
            Console.WriteLine(result);
            */
            #endregion

            #region V3   Pedir números ao user

            // 1. Declarar as variáveis

            double number01, number02, result;

            // 2. Pedir valores ao user
            Console.WriteLine("Number 1: ");
            number01= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            number02 = Convert.ToDouble(Console.ReadLine());

            // 3. Calcular a média
            Console.WriteLine("média= ");

            result = (number01+ number02) / 2;
            Console.WriteLine(result);

            Console.ReadKey();
            #endregion

        }
    }
}

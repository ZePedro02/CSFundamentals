using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D00_Utility
{
    public class Utility
    {

        public static void WriteTitle( string title,string beginTitle="\n\n\n", string endTitle="\n")
        {
            /*
              Console.Write("\n---------------------------------");
                Console.Write("\n-------Matriz------");
                Console.Write("\n---------------------------------\n\n\n");
            */

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{beginTitle}{new string('-', 50)}");

            Console.WriteLine(title.ToUpper());

            Console.WriteLine($"{new string('-', 50)}{endTitle}");

            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void setUniCode()
        {
         //  Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
            Console.OutputEncoding = Encoding.UTF8;
           // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
        }


        public static void terminateConsole()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\n\nPrima qualquer tecla para terminar.");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }

        public static void pauseConsole()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n\nPrima qualquer tecla para continuar.");

            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}

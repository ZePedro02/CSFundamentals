using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace D11_Methods
{
    internal class Method
    {
        #region 1. Void - procedimento (n devolve valor)
        public void procedure ()
        {

            string message = "Método void (procedimento- não devolve valor)";
            Console.WriteLine($"{message}");
        
        }
        #endregion

        #region 2. Método No Void- função (devolve valor)
        public int function()
        {
            int v1, v2, result;
            v1 = 10;
            v2 = 20;
            result = v1 + v2;
            return result;
        }
        #endregion


        #region 3. Método com parametros obrigatórios

        public int functionSum3Numbers(int v1,int v2, int v3)
        {
            int  result;
            result= v1 + v2 + v3;
            return result;
        }

        #endregion

        #region 4. Método com parametros opcionais
        public int functionSum4Numbers(int v1, int v2, int v3=0, int v4=0)
        {
            int result;
            result = v1 + v2 + v3+ v4;
            return result;
        }
        #endregion

        #region 5. Método com parametros por valor
        public void PassingValues(int value)
        {

            value = 10;

            Utility.WriteMessage($"O valor de value é {value}", "\n");//10

        }
        #endregion

        #region 6. Método com parametros por referencia
        public void PassingValuesRef(ref int valueRef)
        {

            valueRef = 10;

            Utility.WriteMessage($"O valor de value é {valueRef}", "\n");//10

        }
        #endregion

        #region 7. Método por instância
        public void InstanceMethod()
        {

            Utility.WriteMessage("Um método de instância é chamada através de um objeto da classe (instância)","","\n");
        
        }
        #endregion

        #region 8. Método estático
        public static void StaticMethod()
        {
            Utility.WriteMessage("Um método de instância é chamada diretamente na classe", "", "\n");
        }
        #endregion

        #region 9. Sobrecarga de métodos (overload)
        public static void WriteMessage(string message)
        {
            //message = message.ToUpper;
            //Console.WriteLine tem 19 overloads
            // Console.WriteLine();
            // Console.WriteLine("aaa");
            // Console.WriteLine(true);
            // Console.WriteLine(1);
            Utility.WriteMessage(message.ToUpper());
            ;
        }
      
        public static void WriteMessage(string message1, string message2)
        {
            //message = message.ToUpper;
            //Console.WriteLine tem 19 overloads
            // Console.WriteLine();
            // Console.WriteLine("aaa");
            // Console.WriteLine(true);
            // Console.WriteLine(1);
            Utility.WriteMessage($"{message1.ToLower()}{message2.ToLower()}");
            ;
        }
        public static void WriteMessage(int num)
        {
            //message = message.ToUpper;
            //Console.WriteLine tem 19 overloads
            // Console.WriteLine();
            // Console.WriteLine("aaa");
            // Console.WriteLine(true);
            // Console.WriteLine(1);
            Utility.WriteMessage($"{num}º overload");
            ;
        }
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.setUniCode();
            #region 1. Void - procedimento (n devolve valor)
            Utility.WriteTitle("Método void", "");
            Method method01 = new Method();
            method01.procedure();

            #endregion

            #region 2. Método No Void- função (devolve valor)
            Utility.WriteTitle("2. Método No Void- função (devolve valor)");
            int result;
            result = method01.function();
            Utility.WriteMessage($"O resultado é: {result}");
            #endregion


            #region 3. Método com parametros obrigatórios
            Utility.WriteTitle("3. Método com parametros obrigatórios");
            int resultsum = method01.functionSum3Numbers(11, 22, 33);
            Utility.WriteMessage($"O resultado é {resultsum}");

            #endregion

            #region 4. Método com parametros opcionais
            Utility.WriteTitle("3. Método com parametros obrigatórios");
            int resultsum4 = method01.functionSum4Numbers(11, 22);
            Utility.WriteMessage($"O resultado é {resultsum4}");

            #endregion




            #region 5. Método com parametros por valor
            Utility.WriteTitle("5. Método com parametros por valor");
            int value = 1;
            Utility.WriteMessage($"O valor de value é {value}", "\n");//1

            method01.PassingValues(value);

            Utility.WriteMessage($"O valor de value é {value}", "\n");//1
            #endregion

            #region 6. Método com parametros por referência

            Utility.WriteTitle("6. Método com parametros por referência");
            int valueRef = 1;
            Utility.WriteMessage($"O valor de value é {valueRef}", "\n");//1

            method01.PassingValuesRef(ref valueRef);

            Utility.WriteMessage($"O valor de value é {valueRef}", "\n");//10

            #endregion

            #region 7. Método por instância
            Utility.WriteTitle("7. Métodos por instância");

            //criar instancia
            Method method02 = new Method();

            //Chamar o método
            method02.InstanceMethod();

            #endregion

            #region 8. Método estático
            Utility.WriteTitle("8. Métodos estáticos");
            Method.StaticMethod();
            #endregion

            #region 9. Sobrecarga de métodos (overload)
            Utility.WriteTitle("9. Sobrecarga de métodos (overload)");
            Method.WriteMessage("1º overload\n");
            Method.WriteMessage("2º ","OVERLOAD\n");
            Method.WriteMessage(3);


            #endregion
            Utility.terminateConsole();
        }
    }
}

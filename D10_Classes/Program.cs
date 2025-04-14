using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
namespace D10_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Utility.setUniCode();

            #region instanciar a classe person (2 objetos)
            Person person01 = new Person();
            Person person02 = new Person();
            #endregion

            #region Atribur valores às propriedades
            person01.Name = ("a");
            person01.VAT = "123456789";
            person02.Name = ("b");
            person02.VAT = "987654321";
            #endregion



            Utility.terminateConsole();

        }
    }
}

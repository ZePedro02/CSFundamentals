using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;


namespace D06_DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility.setUniCode();

            #region 1. Variavéis
            string string01 = "1";
            string string02 = "2";
            string string03 = "C#";
            int int01 = 10;
            int int02 = 20;
            long long01 = 2000000;
            float float01 = 3.8F;
            double double01 = 10.5;
            bool logical01 = true;

            #endregion

            #region 2. Sem conversão
            Utility.WriteTitle("Sem conversão", "");
            Console.WriteLine(string01 + int01);    // concat 110
            Console.WriteLine( int01+ string01);    //concat 101
            #endregion


            #region 3. Conversão Implícita: combina dados da mesma natureza
            Utility.WriteTitle("Conversão implícita");

            Console.WriteLine(int02+long01);
            Console.WriteLine(float01 +double01);
            Console.WriteLine();

            #endregion

            #region 4. Conversão Explícita
            Utility.WriteTitle("4. Conversão Explícita");
            #region 4.1. Método .ToString()
            Console.Write("String e inteiro -  ");
            Console.WriteLine(string01 + int01.ToString());
            Console.Write("String e long -  ");
            Console.WriteLine(string01 + long01.ToString());
            Console.Write("String e float -  ");
            Console.WriteLine(string01 + float01.ToString());
            Console.Write("String e double -  ");
            Console.WriteLine(string01 + double01.ToString());
            Console.Write("String e logical -  ");
            Console.WriteLine(string01 + logical01.ToString());
            Console.WriteLine();
            #endregion
            #region 4.2. Classe Convert
            Utility.WriteTitle("4.2 Classe Convert");
            Console.Write("String e inteiro -  ");
            Console.WriteLine(Convert.ToInt16(string01)+int01);
            Console.Write("String e inteiro -  ");
            Console.WriteLine(Convert.ToInt16(double01) + int02); // corta a parte decimal

            #endregion
            #region 4.3. Método number.Parse()  - converter strings em números
            Utility.WriteTitle("4.3 Parse");
            Console.Write("String e int -  ");
            Console.WriteLine(int01 + int.Parse(string01));
            Console.Write("String e long -  ");
            Console.WriteLine(long01 + long.Parse(string01));
            Console.Write("String e float -  ");
            Console.WriteLine(float01 + float.Parse(string02));
            Console.Write("String e double -  ");
            Console.WriteLine(double01 + double.Parse(string02));

            #endregion
            #region 4.4. Método number.TryParse()
            Utility.WriteTitle("5. TryParse()");
            int resultNumber01, resultNumber02;
            bool resultSuccess01, resultSuccess02;
            resultSuccess01 = int.TryParse(string01, out resultNumber01); // OK:true --> resultNumber01= 1
            resultSuccess02 = int.TryParse(string03, out resultNumber02); // ERROR --> resultNumber01= 0
            Console.WriteLine($"1. Result: {resultSuccess01}; Out: {resultNumber01}");
            Console.WriteLine($"1. Result: {resultSuccess02}; Out: {resultNumber02}");
            #endregion
            #region 4.5. Operator Cast Números noutros números
            Utility.WriteTitle("5. Conversão CAST");
            Console.WriteLine((long)int01 + long01);
            Console.WriteLine(int01 + (int)long01);
            Console.WriteLine((float)double01+float01);
            Console.WriteLine(double01 + (double)float01);

            #endregion






            #endregion





            Utility.terminateConsole();

        }
    }
}

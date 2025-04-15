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
            Person person05= new Person();
            /*
                        #region instanciar a classe person (2 objetos)  e Atribur valores às propriedades com 1 construtor
                        Person person01 = new Person();
                        Person person02 = new Person();
                        person01.ID = 1;
                        person01.Name = ("a");
                        person01.VAT = "123456789";
                        person01.Phone = "191919191";
                        person01.City = "aaa";
                        person01.Adress = "aa";
                        person01.Country = "aaaa";



                        /*              Chamar o método para o utilizador escrever as informações

                        person02.PersonReadData();

                        #endregion

                        #region instanciar a classe person  e Atribur valores às propriedades com 2 construtor
                            Person person03 = new Person(3, "c");
                        #endregion

                        #region instanciar a classe person  e Atribur valores às propriedades com 3 construtor
                        Person person04 = new Person(4, "d","978987987","92929929","rua x","cidadinha","paizinho");
                        #endregion


                        #region Listar as propriedades
                        person01.PersonWriteData();
                        person02.PersonWriteData();

                        person04.PersonWriteData();

                        #endregion
            */

            person05.PersonReadDataWithValidation();
            person05.PersonWriteData();
            Utility.terminateConsole();

        }
    }
}

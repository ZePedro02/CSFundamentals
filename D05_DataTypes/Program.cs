using System;
using D00_Utility;

namespace D05_DataTypes
{

    class Program
    {

        static void Main(string[] args)

        {
            Utility.setUniCode();
          //  Console.Write("Prima qualquer tecla para terminar.");
           // Console.ReadKey();






            #region 1. Declarar variáveis e criar objetos

            // Variaveis value ficam alojadas na memoria stack, assim que o programa acaba, as variaveis sao apagadas
            byte idade;
            float altura;
            double peso;
            bool inscrito;

            // DateTime é uma estrutura
            DateTime data;
            DateTime hora;
            DateTime agora;
            DateTime dataAtual;
            DateTime dataVazia;

            //Reference Type (objetos) estão alocados na memoria heap só é libertado pelo garbage colector
            string nomeCompleto;
            #endregion

            #region 2. Atribuir valores

            //values
            idade = 10;
            altura = 120.5F;
            peso = 120.5;
            inscrito = true; // bolean
            // Datas, horas
            data = new DateTime(2025, 4, 3);
            hora = new DateTime(2025, 4, 3, 22, 9, 0);
            agora = DateTime.Now;  // Data + hora
            dataAtual = DateTime.Today; // Data
            dataVazia = DateTime.MinValue; //01/01/0001 12:00:0000AM

            nomeCompleto = "ZP";
            #endregion

            #region 3. Declarar e atribuir
            string horario = "19:00 - 20:30; 21:00 - 22:30";
            #endregion

            #region 4. Vetor array single dimension

            //Declarar
            string[] nomes = new string[3]; // 3 linhas, começando é 0

            //Atribuir valores

            nomes[0] = "Ana";
            nomes[1] = "Milena";

            //usar 
           // Console.Write("\n---------------------------------");
           // Console.Write("\n-------Data types - vetor'------");
           // Console.Write("\n---------------------------------\n\n\n");
            Utility.WriteTitle("Data types- Vetor");
            Console.WriteLine("Nome: ");
            nomes[2] = Console.ReadLine();

            #endregion

            #region 5. Matriz (array multi dimensional)

            //Declarar os elementos que equero (3 linhas e 2 colunas)
            string[,] turma = new string[3, 2];

            //Atribuir valores no array multi

            turma[0, 0] = "Ana";
            turma[0, 1] = "Porto";
            turma[1, 0] = "Espinho";
            turma[1, 1] = "Milena";
            turma[2, 0] = "Amélia";
            Console.WriteLine("Localidade da/o " + turma[2, 0]);
            turma[2, 1] = Console.ReadLine();

            #region  Trabalhar na consola

            #endregion




            #endregion Array multi

            #region 6. Trabalhar na consola
            #region  reference type
            /*
            Console.Write("\n---------------------------------");
            Console.Write("\n-------Reference types ------");
            Console.Write("\n---------------------------------\n\n\n");
            
              Utility.WriteTitle("\n", "Reference type", "\n\n\n");
             */
            Utility.WriteTitle("Reference type");

            Console.WriteLine("Nome completo: " + nomeCompleto);
            #endregion

            #region  Value types
            /*
            Console.Write("\n---------------------------------");
            Console.Write("\n-------Value types------");
            Console.Write("\n---------------------------------\n\n\n");
            */
            Utility.WriteTitle("Value Types");

            Console.WriteLine("Idade: " + idade.ToString());
            Console.WriteLine("Altura: " + altura.ToString());
            Console.WriteLine("Peso: " + peso.ToString());
            Console.WriteLine("Inscrito: " + inscrito.ToString());

            Console.WriteLine("Data: " + data.ToString());
            Console.WriteLine("Hora: " + hora.ToString());
            Console.WriteLine("Agora: " + agora.ToString());
            Console.WriteLine("Data atual: " + dataAtual.ToString());
            Console.WriteLine("Data vazia: " + dataVazia.ToString());

            #endregion

            #region Array uni (vetor)
            /*
            Console.Write("\n---------------------------------");
            Console.Write("\n------ vetor------");
            Console.Write("\n---------------------------------\n\n\n");
            */
            Utility.WriteTitle("Vetor");
            // v1- Concatenação
            Console.WriteLine("Olá " + nomes[0] + " " + nomes[1] + " " + nomes[2]);

            //v2- placeholder

            /*  Console.WriteLine("Olá {0} {1} {2}", nomes[0], nomes[1], nomes[2]);  // Olá Ana, Milna, José

              Console.WriteLine("Olá {0} {1} {2}", nomes[2], nomes[0], nomes[1]);  // Olá José, Ana, Milena
              */

            // String interpolation
            Console.WriteLine($"Olá {nomes[0]}, {nomes[1]}, {nomes[2]}.");

            Utility.pauseConsole();
            //v1-
            #endregion

            #region Array multi (Matriz)
            /*
                        Console.Write("\n---------------------------------");
                        Console.Write("\n-------Matriz------");
                        Console.Write("\n---------------------------------\n\n\n");
            */
            Utility.WriteTitle("Matriz");
            Console.WriteLine("1. " + turma[0, 0] + ", " + turma[0, 1]);
            Console.WriteLine("2. " + turma[1, 0] + ", " + turma[1, 1]);
            Console.WriteLine("3. " + turma[2, 0] + ", " + turma[2, 1]);
            #endregion

            //v2 place holder

            Console.WriteLine("\n\n\n1.Localidade- {0}, Nome- {1} ", turma[0, 0], turma[0, 1]);
            Console.WriteLine("2.Localidade- {0}, Nome- {1} ", turma[1, 0], turma[1, 1]);
            Console.WriteLine("3.Localidade- {0}, Nome- {1} \n\n\n", turma[2, 0], turma[2, 1]);

            //v3 string interpolation
            Console.WriteLine($"1. Localidade- {turma[0, 0]}, Nome {turma[0, 1]}");
            Console.WriteLine($"2. Localidade- {turma[1, 0]}, Nome {turma[1, 1]}");
            Console.WriteLine($"3. Localidade- {turma[2, 0]}, Nome {turma[2, 1]}");

            #endregion
            Utility.terminateConsole();
        }
    }

}

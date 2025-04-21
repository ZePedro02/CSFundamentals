using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D05_DataTypesArrays
{
    internal class Arrays
    {

        #region MyRegion
        // vetor- array single dimensional
        internal static void ArraySingle01()
        {
            Utility.setUniCode();
            //Declarar
            int[] vetor = new int[5];


            //Atribuir manualmente
            /*
                        vetor[0] = 10;

                        vetor[1] = 20;

                        vetor[2] = 30;

                        vetor[3] = 40;

                        vetor[4] = 50;

            */
            //Atribuir automaticamente

            for (int i = 0; i < 5; i++)
            {
                if (i > 0)
                {
                    vetor[i] = vetor[i - 1] + 10;
                }
                else vetor[i] = 10;
            }


            //Listar for
            Utility.WriteTitle("Vetor", "");
            for (int i = 0; i < 5; i++)
            {
                Utility.WriteMessage($"vetor[{i}] = {vetor[i]}", "\n");
            }


        }

        internal static void ArraySingle02()
        {
            //Declarar
            string[] cidades =
            {
                "Porto",
                "Roma",
                "Paris",
                "Dublin"
            };


            //Atribuir automaticamente

            //Listar com foreach
            Utility.WriteTitle("Cidades");
            foreach (string cid in cidades)
            {
                Utility.WriteMessage(cid, "", "\n");

            }
             
        }


        #endregion
        internal static void ArrayMulti01()
        {
            //Declarar 2x3
            int[,] matriz = new int[2, 3];

            //atribuir
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;

            matriz[0, 2] = 3;

            matriz[1, 0] = 4;

            matriz[1, 1] = 5;

            matriz[1, 2] = 6;


            //listar com dimensões manualmente

            Utility.WriteTitle("Matriz");
            /*
            for(int r = 0;r < 2;r++)
            {
                Console.WriteLine();
                for (int c = 0; c < 3; c++)
                {
                    Utility.WriteMessage($"Matriz [{r},{c}] = {matriz[i,j]} ","");
                }
            }
            */
            //listar com dimensões manualmente
            for (int r = 0; r < (matriz.GetLength(0)); r++)
            {

                for (int c = 0; c < (matriz.GetLength(1)); c++)
                {
                    Utility.WriteMessage($"{matriz[r, c]}\t", "");
                }
                Console.WriteLine();
            }

        }

        internal static void ArrayMulti02()
        {
            string[,] turma =
            {
            { "1","Ana","Ana@email.com","911111111","Porto","Porto"},
            { "2","Cristiano","Cristiano@email.com","922222222","ribeirao","Porto"},
            {"3", "Martim", "Martim@email.com", "93333333", "Calendário", "Porto"},
            {"4", "José M.", "JoseM@email.com", "944444444", "Ruivães", "Porto"},
            {"5", "José P.", "JoseP@email.com", "955555555", "Rio x", "Porto"},
            {"6", "Sandra", "Sandra@email.com", "966666666", "Sítio", "Porto"},
            {"7", "Wilson", "Wilson@email.com", "977777777", "Local Y", "Porto"}
            }
            ;
            Utility.WriteTitle("Turma");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Núm\t Nome \t E-mail \t Telefone\t Localidade\t Cidade");
            Console.WriteLine($"{"Núm" , -5}{"Nome", -15}{"E-mail", -30}{"Telefone",-12}{"Localidade" ,-20}{"Cidade",-20}");
            Console.WriteLine(new string('-', 90));
            Console.ForegroundColor = ConsoleColor.White;

            for (int r = 0; r < (turma.GetLength(0)); r++)
            {

                for (int c = 0; c < (turma.GetLength(1)); c++)
                {
                    //  Utility.WriteMessage($"{turma[r, c]} \t", "");
                    switch (c)
                    {
                        case 0:
                            Utility.WriteMessage($"{turma[r, c], -5}", "");
                            break;
                        case 1:
                            Utility.WriteMessage($"{turma[r, c],-15}", "");
                            break;
                        case 2:
                            Utility.WriteMessage($"{turma[r, c],-30}", "");
                            break;
                        case 3:
                            Utility.WriteMessage($"{turma[r, c],-12}", "");
                            break;
                        case 4:
                            Utility.WriteMessage($"{turma[r, c],-20}", "");
                            break;
                        case 5:
                            Utility.WriteMessage($"{turma[r, c],-20}", "");
                            break;
                        case 6:
                            Utility.WriteMessage($"{turma[r, c],-15}", "");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

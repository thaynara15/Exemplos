using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] matriz = new string[2, 2]; //linhas, colunas
            //matriz[0, 0] = "Linha 0 - Coluna 0";
            //matriz[1, 0] = "Linha 1 - Coluna 0";

            //matriz[0, 1] = "Linha 0 - Coluna 1 =<";
            //matriz[1, 1] = "Linha 1 - Coluna 1";

            //Console.WriteLine(matriz[0,1]);

            int[,] matInt = new int[,] { 
               { 10, 30, 80 }, 
               { 100, 5000, 750 },
               { -500, 937, 198 }
            };

            Console.WriteLine(matInt[2,1]);

            Console.ReadKey();
        }
    }
}

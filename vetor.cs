using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetDiaSemana = new string[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado",
            "Domingo" //não posso colocar virgula então ele não vai continuar
            };

            //string[] vetString = new string[6]; //Declaro o vetor de string com 6

            //vetString[0] = "string_a"; //Define um valor para o indice 0
            //vetString[1] = "string_b";
            //vetString[2] = "string_c";
            //vetString[3] = "string_d";
            //vetString[4] = "Thaynara Martins";
            //vetString[5] = "string_f";

            //Console.WriteLine(vetString[4]);

            int diaSemana = 4;

            Console.WriteLine(vetDiaSemana[diaSemana]);

            Console.ReadKey();  
        }
    }
}

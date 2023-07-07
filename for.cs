using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vetDiaSemana = new string[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado",   
            "Domingo"

            };

            for (int i = 0; i < vetDiaSemana.Length; i++)
            {
                Console.WriteLine(vetDiaSemana[i]);
            }

            Console.ReadKey();
        }
    }
}

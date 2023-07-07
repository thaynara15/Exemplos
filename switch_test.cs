using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_test
{
    class Program
    {
        private static int dia;

        static void Main(string[] args)
        {

            Console.WriteLine("Dias da semana");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 = Segunda");
            Console.WriteLine("2 = Terça");
            Console.WriteLine("3 = Quarta");
            Console.WriteLine("4 = Quinta");
            Console.WriteLine("5 = Sexta");
            Console.WriteLine("6 = Sábado");
            Console.WriteLine("7 = Domingo");
            Console.ResetColor();

            int dia;
            Console.Write("Informe um dia: ");
            int.TryParse(Console.ReadLine(), out dia);

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terça");
                    break;
                case 3:
                    Console.WriteLine("Quarta");
                    break;
                case 4:
                    Console.WriteLine("Quinta");
                    break;
                case 5:
                    Console.WriteLine("Sexta");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("O dia informado é inválido!");
                    break;
            }

            //int dia;
            //Console.Write("Informe um dia ");
            //int.TryParse(Console.ReadLine(), out dia);

            //if (dia == 1) 
            //{
            //    Console.WriteLine("Segunda");
            //}
            //else if (dia == 2)
            //{
            //    Console.WriteLine("Terça");
            //}
            //else if (dia == 4) 
            //{
            //    Console.WriteLine("Quarta");
            //}
            //else
            //{
            //    Console.WriteLine("Dia inválido");
            //}


            Console.ReadKey();
        }
    }
}

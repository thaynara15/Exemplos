using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            ////While = enquanto

            //While (Condição) {
            //    [cod]  
            //}

            //int pos = 0;

            //while (pos < 10000) {
            //    Console.WriteLine(pos);

            //    pos = (pos + 1);
            //}

            //Console.ReadKey();

            //string[] vetDiaSemana = new string[] {
            //"Segunda-feira",
            //"Terça-feira",
            //"Quarta-feira",
            //"Quinta-feira",
            //"Sexta-feira",
            //"Sábado",
            //"Domingo",
            //"Feriado"
            //};

            //int pos = 0;
            //while (pos < vetDiaSemana.Length)
            //{

            //    Console.WriteLine(vetDiaSemana[pos]);
            //    pos++;

            //}

            Console.WriteLine("MENU");
            Console.WriteLine("1 - Olá, bom dia");
            Console.WriteLine("2 - Olá, boa tarde");
            Console.WriteLine("3 - Olá, boa noite");
            Console.WriteLine("4 - Olá, sair");

            int opcao;
            int.TryParse(Console.ReadLine(), out opcao);

            while (opcao != 4) 
            {
                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Olá, bom dia");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Olá, boa tarde");
                            break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;   
                        Console.WriteLine("Olá, boa noite");
                            break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor inválido");
                            break;

                }

                Console.WriteLine("Precione uma tecla para continuar");
                Console.ReadKey();
                Console.Clear(); // limpa os textos console

                Console.WriteLine("MENU");
                Console.WriteLine("1 - Olá, bom dia");
                Console.WriteLine("2 - Olá, boa tarde");
                Console.WriteLine("3 - Olá, boa noite");
                Console.WriteLine("4 - Olá, sair");

                int.TryParse(Console.ReadLine(), out opcao);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace if_else
{
    class Program
    {
        private static int idade;

        static void Main(string[] args)
        {
            int idade;
            Console.Write("Informe a sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            char sexo;
            Console.WriteLine("Informe o seu sexo (M ou F): ");
            char.TryParse(Console.ReadLine().ToLower(), out sexo);


            bool temIngresso = false;
            //exemplo_03
            if (temIngresso && idade >= 18 || sexo == 'f' && idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Olá, pode entrar");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não pode entrar");
            }

            //[exemplo_02]
            //if (idade >= 18 || sexo == 'f')
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Olá, pode entrar");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Você não pode entrar");
            //}

            //if (idade >= 18)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Olá, pode entrar");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Você não pode entrar");
            //}

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodos_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //indexof - Retorna a posição de um caracter, retorna -1 se não encontrar nada
            //tostring - Faz uma conversão de valor para string
            //toupper - Converte todos os caracteres para maiúscula
            //tolower - Converte todos os caracteres para minuscula
            //string.format
            //string.empty - Define um valor vazio nome = string.Empty; 
            //trim
            //replace

            string strUsuario = Console.ReadLine();

            //Console.WriteLine(strUsuario.IndexOf('@'));
            //string mes = DateTime.Now.Month.ToString();

            //Console.WriteLine(strUsuario.ToLower());

            //Console.WriteLine(string.Format("Olá, {0}, agora são {1}:{2}", strUsuario, DateTime.Now.Hour, DateTime.Now.Minute));

            string senha = " 0 adda afaff faffa affa dsa afsfa 0 ";
            //Console.WriteLine(senha);
            //Console.WriteLine(senha.Trim().Replace(" ", string.Empty));
            string frase = "Coma muito banana";

            Console.WriteLine(frase.Replace("banana", "maça"));


            Console.ReadKey();
        }
    }
}

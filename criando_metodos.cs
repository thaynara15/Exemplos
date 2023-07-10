using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace criando_metodos
{
    class Program
    {
        public int Consulta { get; private set; }

        static void Main(string[] args)
        {
            Program p = new Program();

            //double resultado = p.Soma(15);
            //Console.WriteLine(resultado);
            //p.ExibeMensagem();

            Console.WriteLine(p.AjusteSalarial(2500));
            Console.ReadKey();
        }

        double Soma(double multiplicacao, int multiplicador = 2)
        {
            //multiplicação + multiplicador
            return (multiplicacao * multiplicador);
        }

        double AjusteSalarial(double salario)
        {
            if (salario < 1500) 
            {
                salario = salario * 1.5;
            } 
            else {
                salario = salario * 1.2;

            }

            return salario;
        }

        void ExibeMensagem()
        {
            Console.WriteLine("..:MENU::.");
            Console.WriteLine("1 = Compras");
            Console.WriteLine("2 = Consulta");
            Console.WriteLine("3 = Sair");
            Console.WriteLine("Entre com uma ação: ");
        }
    }
}

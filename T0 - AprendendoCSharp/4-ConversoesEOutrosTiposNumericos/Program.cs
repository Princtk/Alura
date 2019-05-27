using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //double ocupa 64bits
            double salario = 1200.50;
            //int ocupa 32bits
            int salarioEmInteiro = (int) salario;

            //long ocupa 64bits
            long produtos = 2400;

            //short ocupa 16bits
            short idade = 16;

            //float ocupa 32bits
            float altura = 1.80f;

            Console.WriteLine(altura + " é a sua altura");
            Console.WriteLine("Idade = " + idade);
            Console.WriteLine("Produtos = " + produtos);
            Console.WriteLine("Salario em inteiro = " + salarioEmInteiro);
            Console.ReadLine();

        }
    }
}

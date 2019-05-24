using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3");

            double salario = 1220.70;
            double idade;
            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);
            Console.Write("Salário = " + salario + "\n");
            Console.WriteLine("Press Enter para sair");
            Console.ReadLine();

        }
    }
}

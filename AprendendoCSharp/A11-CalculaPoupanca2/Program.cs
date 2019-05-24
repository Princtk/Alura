using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            Console.WriteLine("Executando o projeto 11");
            for(int i = 1; i <= 12; i++)
            {
                valorInvestido *= 0.0036;
                Console.WriteLine(
                        "Após " + i +
                        " meses, você terá R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}

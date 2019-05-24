using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente c = new ContaCorrente(876, 86712540);



            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente a = new ContaCorrente(831, 3992194);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(c);
            Console.WriteLine(c.Agencia);
            Console.WriteLine(c.Numero);
            Console.WriteLine(c.Titular.Nome);

            Console.ReadLine();


        }
    }
}

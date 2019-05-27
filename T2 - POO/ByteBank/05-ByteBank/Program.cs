using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cliente kruger = new Cliente();
            //kruger.nome = "kruger";
            //kruger.cpf = "049.392.441-62";
            // kruger.profissao = "Desenvolvedor";

            ContaCorrente conta = new ContaCorrente();
            // conta.titular = kruger;

            //Console.WriteLine(kruger.profissao);

            Console.WriteLine(conta.titular.profissao);
            conta.titular.profissao = "kappa";
            Console.WriteLine(conta.titular.profissao);
            //Console.WriteLine(kruger.profissao);
            Console.ReadLine();
        }
    }
}

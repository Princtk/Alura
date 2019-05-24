using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = 150;
            Cliente cliente = new Cliente();
            cliente.Nome = "kruger";
            cliente.CPF = "005.487.450-56";
            cliente.Profissao = "desenvolvedor";

            conta.Titular = cliente;
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Titular.Profissao);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}

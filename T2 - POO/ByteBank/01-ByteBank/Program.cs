using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaKruger = new ContaCorrente();
            contaKruger.titular = "Kruger";
            contaKruger.agencia = 863;
            contaKruger.numero = 93265;
            contaKruger.saldo = 150.42;

            Console.WriteLine("Titular: " + contaKruger.titular);
            Console.WriteLine("Agencia: " + contaKruger.agencia);
            Console.WriteLine("Numero da conta: " + contaKruger.numero);
            Console.WriteLine("Saldo: " + contaKruger.saldo);
            Console.WriteLine("Objeto: " + contaKruger);
            Console.ReadLine();
        }
    }
}

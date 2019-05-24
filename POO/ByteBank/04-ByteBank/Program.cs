using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaKruger = new ContaCorrente();
            ContaCorrente contaKrugao = new ContaCorrente();
            contaKruger.titular = "Kruger";
            contaKruger.saldo = 100;

            Console.WriteLine(contaKruger.saldo);
            contaKruger.Saque(300);

            contaKruger.Depositar(180);

            contaKruger.Transferir(103, contaKrugao);

            Console.WriteLine(contaKruger.saldo);
            Console.WriteLine(contaKrugao.saldo);
            Console.ReadLine();
            
        }
    }
}

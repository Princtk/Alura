using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente kruger = new ContaCorrente();
            ContaCorrente krugao = new ContaCorrente();

            kruger.titular = "Kruger";
            kruger.agencia = 863;
            kruger.numero = 93265;
            kruger.saldo = 150.42;

            krugao.titular = "Kruger";
            krugao.agencia = 863;
            krugao.numero = 93265;
            krugao.saldo = 150.42;

            kruger = krugao;

            Console.WriteLine(kruger == krugao);
            Console.ReadLine();
        }
    }
}

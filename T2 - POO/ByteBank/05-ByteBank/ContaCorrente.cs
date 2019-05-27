using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo;


        public bool Saque(int valor)
        {
            if (this.saldo < valor)
            {
                return false;


            }
            else
            {
                this.saldo -= valor;
                return true;
            }

        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente pessoaRecebe)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                pessoaRecebe.saldo += valor;
                return true;
            }
        }


    }

}



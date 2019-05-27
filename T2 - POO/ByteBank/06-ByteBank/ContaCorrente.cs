using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular { get; set; }





        public int Agencia{ get; set; }
        public int Numero { get; set; }
        public double _saldo;


       

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }



        public bool Saque(int valor)
        {
            if (this._saldo < valor)
            {
                return false;


            }
            else
            {
                this._saldo -= valor;
                return true;
            }

        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente pessoaRecebe)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                pessoaRecebe._saldo += valor;
                return true;
            }
        }


    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _CPF;
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                //Aqui vai a lógica pra valiar o CPF
                _CPF = value;
            }
        }
        public string Profissao { get; set; }

    }
}

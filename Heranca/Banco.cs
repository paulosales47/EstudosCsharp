using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa.Financas.Entidade
{
    public class Banco
    {
        public Conta[] arrayConta { get; private set; }
        private int index { get; set; }

        public Banco()
        {
            this.arrayConta = new Conta[10];
            this.index = 0;
        }

        public void Adiciona(Conta conta)
        {
            this.arrayConta[index] = conta;
            this.index++;
        }
    }
}

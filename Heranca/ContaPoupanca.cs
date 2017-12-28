using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casa.Financas.Interface;

namespace Casa.Financas.Entidade
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public override void Saca(double valor) {

            this.saldo -= valor + 0.1;
        }

        public override void Deposita(double valor) {
            this.saldo = valor;
        }

        public double CalculaAtributo()
        {
            return this.saldo * 0.02;
        }
    }
}
